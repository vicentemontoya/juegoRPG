namespace juegoRPG
{
    /// <summary>
    ///  Guarda y recupera la partida en un archivo de texto.
    ///
    ///  Formato (un registro por linea, campos separados por |):
    ///      VERSION|1
    ///      PERSONAJE|Arthos|Guerrero|1|85|120|18|12|15
    ///      ITEM|Pocion de vida|Consumible|30|3|False
    ///      ITEM|Espada de hierro|Arma|6|1|True
    ///
    ///  El archivo queda junto al ejecutable, asi que la partida sobrevive
    ///  a cerrar y volver a abrir el juego.
    /// </summary>
    public static class GestorPartida
    {
        public const string NombreArchivo = "partida.txt";
        private const string Version = "1";

        public static string Ruta
        {
            get { return Path.Combine(AppContext.BaseDirectory, NombreArchivo); }
        }

        public static bool ExistePartida()
        {
            return File.Exists(Ruta);
        }

        // ----------------- Guardar -----------------

        /// <summary>
        ///  Escribe la partida en disco. Devuelve false (con el motivo en mensaje)
        ///  si el archivo no se pudo escribir.
        /// </summary>
        public static bool Guardar(EstadoPartida partida, out string mensaje)
        {
            if (partida == null || partida.Jugador == null)
            {
                mensaje = "No hay ninguna partida que guardar.";
                return false;
            }

            try
            {
                List<string> lineas = new List<string>();
                lineas.Add("VERSION|" + Version);

                Personaje j = partida.Jugador;
                lineas.Add(string.Join("|", "PERSONAJE", j.Nombre, j.TipoPersonaje,
                    j.Nivel, j.Vida, j.VidaMaxima, j.Ataque, j.Defensa, j.ProbabilidadCritico));

                foreach (Item item in partida.Inventario)
                {
                    lineas.Add(string.Join("|", "ITEM", item.Nombre, item.Tipo,
                        item.Valor, item.Cantidad, item.Equipado));
                }

                File.WriteAllLines(Ruta, lineas);
                mensaje = "Partida guardada en " + NombreArchivo + ".";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo guardar la partida: " + ex.Message;
                return false;
            }
        }

        // ----------------- Cargar -----------------

        /// <summary>
        ///  Lee la partida del disco y la reconstruye.
        ///  Devuelve null si el archivo no existe, esta vacio o viene corrupto;
        ///  en ese caso "mensaje" explica que paso.
        /// </summary>
        public static EstadoPartida? Cargar(out string mensaje)
        {
            if (!ExistePartida())
            {
                mensaje = "Todavia no hay ninguna partida guardada.";
                return null;
            }

            string[] lineas;
            try
            {
                lineas = File.ReadAllLines(Ruta);
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo leer el archivo: " + ex.Message;
                return null;
            }

            if (lineas.Length == 0)
            {
                mensaje = "El archivo de partida esta vacio.";
                return null;
            }

            Personaje? jugador = null;
            List<Item> objetos = new List<Item>();

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue; // una linea en blanco no es un error
                }

                string[] datos = linea.Split('|');

                if (datos[0] == "PERSONAJE")
                {
                    jugador = LeerPersonaje(datos);
                    if (jugador == null)
                    {
                        mensaje = "El archivo esta danado: la linea del personaje no es valida.";
                        return null;
                    }
                }
                else if (datos[0] == "ITEM")
                {
                    Item? item = LeerItem(datos);
                    if (item != null)
                    {
                        objetos.Add(item);
                    }
                    // Un objeto malo se ignora: no vale la pena botar toda la partida por el.
                }
                // VERSION y cualquier registro desconocido se ignoran.
            }

            if (jugador == null)
            {
                mensaje = "El archivo no contiene ningun personaje.";
                return null;
            }

            EstadoPartida partida = new EstadoPartida(jugador);
            partida.Inventario = objetos;
            partida.Historial.Add("Partida de " + jugador.Nombre + " recuperada desde " + NombreArchivo + ".");

            mensaje = "Partida de " + jugador.Nombre + " cargada correctamente.";
            return partida;
        }

        /// <summary>PERSONAJE|nombre|clase|nivel|vida|vidaMaxima|ataque|defensa|critico</summary>
        private static Personaje? LeerPersonaje(string[] datos)
        {
            if (datos.Length < 9)
            {
                return null;
            }

            string nombre = datos[1].Trim();
            string clase = datos[2].Trim();

            if (nombre.Length == 0 || clase.Length == 0)
            {
                return null;
            }

            int nivel, vida, vidaMaxima, ataque, defensa, critico;

            if (!int.TryParse(datos[3], out nivel)) return null;
            if (!int.TryParse(datos[4], out vida)) return null;
            if (!int.TryParse(datos[5], out vidaMaxima)) return null;
            if (!int.TryParse(datos[6], out ataque)) return null;
            if (!int.TryParse(datos[7], out defensa)) return null;
            if (!int.TryParse(datos[8], out critico)) return null;

            if (vidaMaxima < 1)
            {
                return null;
            }

            // El constructor deja la vida llena; despues se baja a la que venia guardada.
            Personaje personaje = new Personaje(nombre, clase, nivel, vidaMaxima,
                                                ataque, defensa, critico, 0);
            personaje.RestaurarVida(vida);
            return personaje;
        }

        /// <summary>ITEM|nombre|tipo|valor|cantidad|equipado</summary>
        private static Item? LeerItem(string[] datos)
        {
            if (datos.Length < 6)
            {
                return null;
            }

            string nombre = datos[1].Trim();
            string tipo = datos[2].Trim();

            if (nombre.Length == 0)
            {
                return null;
            }

            if (tipo != Item.Consumible && tipo != Item.Arma && tipo != Item.Escudo)
            {
                return null;
            }

            int valor, cantidad;
            if (!int.TryParse(datos[3], out valor)) return null;
            if (!int.TryParse(datos[4], out cantidad)) return null;

            bool equipado;
            if (!bool.TryParse(datos[5], out equipado))
            {
                equipado = false;
            }

            Item item = new Item(nombre, tipo, valor, cantidad);

            // Importante: el bono del equipo YA viene sumado en el ataque y la defensa
            // que se guardaron, asi que aqui solo se marca la bandera. Si se volviera a
            // llamar a Equipar(), el bono se sumaria dos veces.
            item.Equipado = equipado && item.EsEquipable;
            return item;
        }
    }
}
