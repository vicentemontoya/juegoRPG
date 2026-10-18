namespace juegoRPG
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada. El juego parte en el menu principal, no en el combate:
        ///  desde ahi se decide si empezar una partida nueva o recuperar una guardada.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMenuPrincipal());
        }
    }
}
