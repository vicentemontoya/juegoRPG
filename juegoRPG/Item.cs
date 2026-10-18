using System;
using System.Collections.Generic;
using System.Text;

namespace juegoRPG
{
    public class Item
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Valor { get; set; }
        public int Cantidad { get; set; }

        public Item(string nombre, string tipo, int valor, int cantidad)
        {
            Nombre = nombre;
            Tipo = tipo;
            Valor = valor;
            Cantidad = cantidad;

        }
    }
}
