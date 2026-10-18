using System;
using System.Collections.Generic;
using System.Text;

namespace juegoRPG
{
    public class Inventario
    {
        public List<Item> Objetos { get; set; }

        public Inventario()
        {
            Objetos = new List<Item>();
        }

        public void AgregarItem(Item item)
        {
            Objetos.Add(item);
        }
    }
}
