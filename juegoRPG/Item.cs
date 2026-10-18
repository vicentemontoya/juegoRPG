namespace juegoRPG
{
    /// <summary>
    ///  Un objeto del inventario. El Tipo decide que se puede hacer con el:
    ///      "Consumible" -> se usa y se gasta (pociones)
    ///      "Arma"       -> se equipa y sube el ataque
    ///      "Escudo"     -> se equipa y sube la defensa
    /// </summary>
    public class Item
    {
        public const string Consumible = "Consumible";
        public const string Arma = "Arma";
        public const string Escudo = "Escudo";

        public string Nombre { get; set; }
        public string Tipo { get; set; }

        /// <summary>Cuanto cura (consumible) o cuanto bonifica (equipable).</summary>
        public int Valor { get; set; }

        public int Cantidad { get; set; }

        /// <summary>Solo para armas y escudos: si su bono esta aplicado al personaje.</summary>
        public bool Equipado { get; set; }

        public bool EsEquipable
        {
            get { return Tipo == Arma || Tipo == Escudo; }
        }

        public bool EsConsumible
        {
            get { return Tipo == Consumible; }
        }

        public Item(string nombre, string tipo, int valor, int cantidad)
        {
            Nombre = nombre;
            Tipo = tipo;
            Valor = valor;
            Cantidad = cantidad < 0 ? 0 : cantidad;
            Equipado = false;
        }

        /// <summary>Texto que se muestra en la lista del inventario.</summary>
        public string Descripcion()
        {
            string texto = Nombre + "  x" + Cantidad;

            if (Tipo == Arma)
            {
                texto = texto + "   (+" + Valor + " ataque)";
            }
            else if (Tipo == Escudo)
            {
                texto = texto + "   (+" + Valor + " defensa)";
            }
            else if (Tipo == Consumible)
            {
                texto = texto + "   (cura " + Valor + ")";
            }

            if (Equipado)
            {
                texto = texto + "   [EQUIPADO]";
            }

            return texto;
        }
    }
}
