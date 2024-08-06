namespace _21
{
    public class AccionesDelJuego
    {
        public static void Welcome()
        {
            Console.WriteLine("██████╗░░█████╗░███████╗░█████╗░███╗░░██╗░█████╗░░██████╗░██╗░░██╗");
            Console.WriteLine("██╔══██╗██╔══██╗╚════██║██╔══██╗████╗░██║██╔══██╗██╔════╝░██║░██╔╝");
            Console.WriteLine("██████╦╝███████║░░███╔═╝██║░░██║██╔██╗██║██║░░██║██║░░██╗░█████═╝░");
            Console.WriteLine("██╔══██╗██╔══██║██╔══╝░░██║░░██║██║╚████║██║░░██║██║░░╚██╗██╔═██╗░");
            Console.WriteLine("██████╦╝██║░░██║███████╗╚█████╔╝██║░╚███║╚█████╔╝╚██████╔╝██║░╚██╗");
            Console.WriteLine("╚═════╝░╚═╝░░╚═╝╚══════╝░╚════╝░╚═╝░░╚══╝░╚════╝░░╚═════╝░╚═╝░░╚═╝\n");
            Console.WriteLine("Bienvenido a Casino El Luis\n");
            Console.WriteLine("Presiona 1 para iniciar o 9 para salir\n");
        }
        public static void StartGame()
        {
            Console.WriteLine("\n");
            Console.WriteLine("¡Elige un numero y aletoriamente jugaras un juego casino!\n");
            Console.ReadLine();
            Juegos.Blackjack();
        }
    }
}
