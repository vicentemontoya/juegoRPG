using System;
using System.Collections.Generic;
using System.Text;

namespace juegoRPG
{
    public class Personajes
    {
        /// <summary>
        /// public const sirve para declarar una constante pública. 
        /// Esto define un valor fijo, inmutable y accesible desde cualquier parte del código, 
        /// cuyo valor debe conocerse en tiempo de compilación
        /// </summary>
        public const int MaximoPociones = 3;
        public const int CuraPorPociones = 25;
        
        /// <summary>
        /// clase para los guerreros
        /// </summary>
        public static readonly string[] Clases = { "Guerrero", "mago", "caballero" };
        /// <summary>
        /// clase para los enemigos
        /// </summary>
        public static readonly string[] ClasesEnemigos = { "orco", "duende", "brujo" };
        public string Nombre { get; set; }
        public string ClasePersonaje { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Nivel { get; set; }
        public int Defensa { get; set; }
        public int VidaMaxima { get; set; }
        public int Pociones { get; set; }

        public bool EstaVivo
        {
            get { return Vida > 0; }
        }
        public Personajes(string nombre, string clasePersonaje, int nivel, int defensa, int vida, int ataque, int pociones)
        {
            Nombre = nombre;
            ClasePersonaje = clasePersonaje;
            Nivel = nivel;
            Defensa = defensa;
            Vida = vida;
            Ataque = ataque;
            Pociones = pociones;

            // Nunca se permiten mas de 3 pociones ni menos de 0.
            if (pociones > MaximoPociones)
            {
                Pociones = MaximoPociones;
            }
            if (pociones < 0)
            {
                Pociones = 0;
            }

            // La vida la elige el usuario en el TextBox "Vida": parte con la vida llena.
            VidaMaxima = vida;
            Vida = vida;
        }
        public int CalcularDano(Personajes objetivo, Random azar)
        {
            int suerte = azar.Next(0,Nivel +1);
            int dano = Ataque + suerte -(objetivo.Defensa / 2);
            
            if(dano< 1)
            {
                dano = 1;
            }
            return dano;
        }
        /// <summary>Resta vida al personaje, sin bajar de 0.</summary>
        public void RecibirDano(int dano)
        {
            Vida = Vida - dano;
            if (Vida < 0)
            {
                Vida = 0;
            }
        }

        /// <summary>Gasta una pocion y devuelve cuanta vida recupero (0 si no le quedan).</summary>
        public int UsarPocion()
        {
            if(Pociones <= 0)
            {
                return 0;
            }
           Pociones = Pociones - 1;

            int vidaAntes = Vida;
            Vida = Vida + CuraPorPociones;
            if(Vida > VidaMaxima)
            {
                Vida = VidaMaxima;
            } 
            return Vida - vidaAntes;
        }


    }

}
