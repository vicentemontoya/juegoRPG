namespace juegoRPG
{
  
    public static class ImagenesPersonaje
    {
        /// <summary>Nombre de la carpeta que viaja junto al ejecutable.</summary>
        public const string Carpeta = "Imagenes";

        // Las imagenes pesan ~250 KB cada una, asi que cada una se lee del disco
        // una sola vez y despues se reutiliza.
        private static readonly Dictionary<string, Image?> cache = new Dictionary<string, Image?>();

        /// <summary>
        ///  Devuelve la imagen del tipo de personaje en ese estado de vida,
        ///  o null si todavia no hay imagenes para ese tipo.
        /// </summary>
        public static Image? Obtener(string tipoPersonaje, EstadoVida estado)
        {
            if (string.IsNullOrWhiteSpace(tipoPersonaje))
            {
                return null;
            }

            string clave = tipoPersonaje.ToLowerInvariant() + "/" + (int)estado;

            if (cache.TryGetValue(clave, out Image? guardada))
            {
                return guardada;
            }

            Image? imagen = LeerDelDisco(tipoPersonaje, estado);
            cache[clave] = imagen;
            return imagen;
        }

        /// <summary>
        ///  La imagen que se muestra como adelanto al elegir el tipo en el ComboBox:
        ///  siempre la 1, el personaje entero.
        /// </summary>
        public static Image? ObtenerVistaPrevia(string tipoPersonaje)
        {
            return Obtener(tipoPersonaje, EstadoVida.Saludable);
        }

        private static Image? LeerDelDisco(string tipoPersonaje, EstadoVida estado)
        {
            string ruta = Path.Combine(AppContext.BaseDirectory, Carpeta,
                                       tipoPersonaje.ToLowerInvariant(),
                                       (int)estado + ".png");

            if (!File.Exists(ruta))
            {
                return null;
            }

            try
            {
                // Se copia a una imagen nueva para no dejar el archivo bloqueado:
                // Image.FromFile mantiene el .png tomado mientras viva la imagen.
                using (MemoryStream memoria = new MemoryStream(File.ReadAllBytes(ruta)))
                using (Image original = Image.FromStream(memoria))
                {
                    return new Bitmap(original);
                }
            }
            catch (Exception)
            {
                // Un archivo corrupto o ilegible no debe botar el juego:
                // el PictureBox simplemente queda vacio.
                return null;
            }
        }
    }
}
