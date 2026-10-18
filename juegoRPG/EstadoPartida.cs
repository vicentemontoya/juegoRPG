namespace juegoRPG
{
    /// <summary>
    ///  Todo lo que compone una partida: el personaje del jugador, su inventario
    ///  y el historial de lo que ha pasado.
    ///
    ///  Esta es LA clase que viaja entre ventanas. Cada formulario la recibe por
    ///  constructor y trabaja sobre el mismo objeto, nunca sobre una copia: por eso
    ///  lo que el inventario le hace al personaje se ve al volver al combate.
    /// </summary>
    public class EstadoPartida
    {
        public Personaje Jugador { get; set; }
        public List<Item> Inventario { get; set; } = new List<Item>();
        public List<string> Historial { get; set; } = new List<string>();

        public EstadoPartida(Personaje jugador)
        {
            Jugador = jugador;
        }

        // ----------------- Crear una partida nueva -----------------

        /// <summary>Estadisticas base de cada clase que puede elegir el jugador.</summary>
        private static readonly (string Clase, int Vida, int Ataque, int Defensa, int Critico)[] Clases =
        {
            ("Guerrero",  100, 18, 12, 15),
            ("Mago",       80, 30,  5, 25),
            ("Caballero",  95, 24,  7, 20),
        };

        /// <summary>Devuelve las estadisticas de una clase, o las del Guerrero si no la encuentra.</summary>
        public static (string Clase, int Vida, int Ataque, int Defensa, int Critico) EstadisticasDe(string clase)
        {
            foreach (var c in Clases)
            {
                if (c.Clase == clase)
                {
                    return c;
                }
            }
            return Clases[0];
        }

        /// <summary>
        ///  Arma una partida nueva: crea el personaje con las estadisticas de su clase
        ///  y le entrega el inventario inicial.
        /// </summary>
        public static EstadoPartida Nueva(string nombre, string clase)
        {
            var baseClase = EstadisticasDe(clase);

            Personaje jugador = new Personaje(nombre, clase, 1, baseClase.Vida,
                baseClase.Ataque, baseClase.Defensa, baseClase.Critico, 0);

            EstadoPartida partida = new EstadoPartida(jugador);
            partida.Inventario.Add(new Item("Pocion de vida", Item.Consumible, 30, 3));
            partida.Inventario.Add(new Item("Espada de hierro", Item.Arma, 6, 1));
            partida.Inventario.Add(new Item("Escudo de madera", Item.Escudo, 5, 1));

            partida.Historial.Add(nombre + " (" + clase + ") entra al torneo.");
            return partida;
        }

        // ----------------- Inventario -----------------

        public Item? BuscarItem(string nombre)
        {
            foreach (Item item in Inventario)
            {
                if (item.Nombre == nombre)
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>Cuantas pociones le quedan al jugador, segun el inventario.</summary>
        public int PocionesDisponibles()
        {
            int total = 0;
            foreach (Item item in Inventario)
            {
                if (item.EsConsumible)
                {
                    total = total + item.Cantidad;
                }
            }
            return total;
        }

        /// <summary>
        ///  Usa un consumible: cura al personaje de verdad y descuenta una unidad.
        ///  Devuelve cuanta vida recupero, o 0 si no se pudo usar.
        /// </summary>
        public int UsarConsumible(Item item)
        {
            if (item == null || !item.EsConsumible)
            {
                return 0;
            }

            // No se puede usar un objeto agotado.
            if (item.Cantidad <= 0)
            {
                return 0;
            }

            if (!Jugador.EstaVivo || Jugador.Vida >= Jugador.VidaMaxima)
            {
                return 0;
            }

            int vidaAntes = Jugador.Vida;
            Jugador.Curar(item.Valor);
            item.Cantidad = item.Cantidad - 1;

            int curado = Jugador.Vida - vidaAntes;
            Historial.Add(Jugador.Nombre + " usa " + item.Nombre + " y recupera " + curado + " de vida.");
            return curado;
        }

        /// <summary>
        ///  Equipa un arma o escudo y aplica su bono al personaje.
        ///
        ///  Antes de aplicarlo quita el que estuviera equipado del mismo tipo, para que
        ///  las bonificaciones NO se acumulen: solo puede haber un arma y un escudo activos.
        /// </summary>
        public bool Equipar(Item item)
        {
            if (item == null || !item.EsEquipable || item.Cantidad <= 0)
            {
                return false;
            }

            // Ya estaba equipado: no hacer nada (si no, el bono se sumaria dos veces).
            if (item.Equipado)
            {
                return false;
            }

            // Quitar el otro objeto del mismo tipo que estuviera puesto.
            foreach (Item otro in Inventario)
            {
                if (otro != item && otro.Tipo == item.Tipo && otro.Equipado)
                {
                    Desequipar(otro);
                }
            }

            if (item.Tipo == Item.Arma)
            {
                Jugador.AplicarBonificacion(item.Valor, 0);
            }
            else
            {
                Jugador.AplicarBonificacion(0, item.Valor);
            }

            item.Equipado = true;
            Historial.Add(Jugador.Nombre + " equipa " + item.Nombre + ".");
            return true;
        }

        /// <summary>Quita el objeto y descuenta su bono del personaje.</summary>
        public bool Desequipar(Item item)
        {
            if (item == null || !item.EsEquipable || !item.Equipado)
            {
                return false;
            }

            if (item.Tipo == Item.Arma)
            {
                Jugador.AplicarBonificacion(-item.Valor, 0);
            }
            else
            {
                Jugador.AplicarBonificacion(0, -item.Valor);
            }

            item.Equipado = false;
            Historial.Add(Jugador.Nombre + " guarda " + item.Nombre + ".");
            return true;
        }
    }
}
