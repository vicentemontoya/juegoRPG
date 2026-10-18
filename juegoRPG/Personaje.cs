namespace juegoRPG
{
    /// <summary>
    ///  Tramos de vida del personaje. El numero de cada estado coincide a proposito
    ///  con el nombre del archivo de imagen: Saludable = 1.png ... Derrotado = 5.png.
    /// </summary>
    public enum EstadoVida
    {
        Saludable = 1,
        Herido = 2,
        MuyHerido = 3,
        Critico = 4,
        Derrotado = 5
    }

    public class ResultadoAtaque
    {
        public int Danio { get; set; }
        public bool FueCritico { get; set; }
    }

    public class Personaje
    {
        public const int MaximoPociones = 3;
        public const int CuraPorPocion = 25;

        public const int CriticoPorDefecto = 15;
        public const int MultiplicadorCritico = 2;

        public static readonly string[] TiposPersonaje = { "Guerrero", "Mago", "Caballero" };
        public static readonly string[] TiposEnemigo = { "Orco", "Duende", "Brujo" };

        private static readonly (string Nombre, string Tipo, int Nivel, int Vida,
                                 int Ataque, int Defensa, int Critico)[] Enemigos =
        {
            ("Grommak",  "Orco",   3, 100, 24, 14, 10),
            ("Zarko",    "Duende", 2, 100, 18,  6, 30),
            ("Malaquir", "Brujo",  4, 100, 30,  8, 20),
        };

        /// <summary>Elige al azar uno de los enemigos de la tabla, con vida y pociones al maximo.</summary>
        public static Personaje CrearEnemigoAleatorio(Random azar)
        {
            var elegido = Enemigos[azar.Next(Enemigos.Length)];

            return new Personaje(elegido.Nombre, elegido.Tipo, elegido.Nivel, elegido.Vida,
                                 elegido.Ataque, elegido.Defensa, elegido.Critico, MaximoPociones);
        }

        public string Nombre { get; private set; }
        public string TipoPersonaje { get; private set; }
        public int Nivel { get; private set; }
        public int Vida { get; private set; }
        public int VidaMaxima { get; private set; }
        public int Ataque { get; private set; }
        public int Defensa { get; private set; }
        public int ProbabilidadCritico { get; private set; }
        public int Pociones { get; private set; }

        public bool EstaVivo
        {
            get { return Vida > 0; }
        }

        public Personaje(string nombre, string tipoPersonaje, int nivel, int vida,
                         int ataque, int defensa, int probabilidadCritico, int pociones)
        {
            Nombre = nombre;
            TipoPersonaje = tipoPersonaje;

            // Ninguna estadistica puede quedar bajo su minimo.
            Nivel = nivel < 1 ? 1 : nivel;
            VidaMaxima = vida < 1 ? 1 : vida;
            Vida = VidaMaxima;
            Ataque = ataque < 1 ? 1 : ataque;
            Defensa = defensa < 0 ? 0 : defensa;

            // La probabilidad de critico queda entre 0% y 50%.
            if (probabilidadCritico < 0) probabilidadCritico = 0;
            if (probabilidadCritico > 50) probabilidadCritico = 50;
            ProbabilidadCritico = probabilidadCritico;

            if (pociones > MaximoPociones) pociones = MaximoPociones;
            if (pociones < 0) pociones = 0;
            Pociones = pociones;
        }

        /// <summary>
        ///  Deja la vida actual en un valor concreto, sin pasar del maximo ni bajar de 0.
        ///  Sirve para reconstruir una partida guardada: el constructor siempre deja la
        ///  vida llena, y un personaje cargado puede venir herido.
        /// </summary>
        public void RestaurarVida(int vidaActual)
        {
            if (vidaActual < 0) vidaActual = 0;
            if (vidaActual > VidaMaxima) vidaActual = VidaMaxima;
            Vida = vidaActual;
        }

        /// <summary>
        ///  Suma (o resta, si viene negativo) los bonos de un objeto equipado.
        ///  El ataque nunca baja de 1 y la defensa nunca baja de 0.
        /// </summary>
        public void AplicarBonificacion(int bonoAtaque, int bonoDefensa)
        {
            Ataque = Ataque + bonoAtaque;
            if (Ataque < 1) Ataque = 1;

            Defensa = Defensa + bonoDefensa;
            if (Defensa < 0) Defensa = 0;
        }

        public int CalcularPorcentajeVida()
        {
            if (VidaMaxima <= 0)
            {
                return 0;
            }
            return (Vida * 100) / VidaMaxima;
        }

        public EstadoVida Estado
        {
            get
            {
                if (!EstaVivo)
                {
                    return EstadoVida.Derrotado;
                }

                int porcentaje = CalcularPorcentajeVida();

                if (porcentaje >= 76) return EstadoVida.Saludable;
                if (porcentaje >= 51) return EstadoVida.Herido;
                if (porcentaje >= 26) return EstadoVida.MuyHerido;
                return EstadoVida.Critico;
            }
        }

        public bool EsGolpeCritico(Random azar)
        {
            return azar.Next(100) < ProbabilidadCritico;
        }

        /// <summary>
        ///  Dano = (ataque + suerte entre 0 y nivel), x2 si es critico,
        ///  menos la mitad de la defensa del objetivo. Siempre hace al menos 1.
        /// </summary>
        public ResultadoAtaque Atacar(Personaje objetivo, Random azar)
        {
            if (!EstaVivo || !objetivo.EstaVivo)
            {
                return new ResultadoAtaque { Danio = 0, FueCritico = false };
            }

            int suerte = azar.Next(0, Nivel + 1);
            int danio = Ataque + suerte;

            bool critico = EsGolpeCritico(azar);
            if (critico)
            {
                danio = danio * MultiplicadorCritico;
            }

            danio = danio - (objetivo.Defensa / 2);

            if (danio < 1)
            {
                danio = 1;
            }

            objetivo.RecibirDanio(danio);

            return new ResultadoAtaque { Danio = danio, FueCritico = critico };
        }

        public void RecibirDanio(int cantidad)
        {
            if (cantidad <= 0)
            {
                return;
            }

            Vida = Vida - cantidad;
            if (Vida < 0)
            {
                Vida = 0;
            }
        }

        public bool Curar(int cantidad)
        {
            if (!EstaVivo || cantidad <= 0)
            {
                return false;
            }

            Vida = Vida + cantidad;
            if (Vida > VidaMaxima)
            {
                Vida = VidaMaxima;
            }
            return true;
        }

        /// <summary>Gasta una pocion y devuelve cuanta vida recupero. Devuelve 0 si no pudo usarla.</summary>
        public int UsarPocion()
        {
            if (Pociones <= 0 || !EstaVivo)
            {
                return 0;
            }

            int vidaAntes = Vida;

            if (!Curar(CuraPorPocion))
            {
                return 0;
            }

            Pociones = Pociones - 1;
            return Vida - vidaAntes;
        }
    }
}
