
using _21;

class Program
{
    static void Main()
    {
        AccionesDelJuego.Welcome();

        while (true)
        {
            Console.Write("Introduce tu opción (1 o 9): \n");
            Console.Write("\n");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    AccionesDelJuego.StartGame();
                    break;
                case "9":
                    Console.WriteLine("Gracias por visitar Casino El Luis. ¡Hasta pronto!");
                    return; // Termina el programa
                default:
                    Console.WriteLine("Opción no válida. Por favor, intenta de nuevo.\n");
                    break;
            }
        }
    }
}

//string cardValue = Generar_Cartas.GenerateCardValue();
//Console.WriteLine($"Te ha salido la carta: {cardValue}");
//// Puedes añadir más lógica de juego aquí