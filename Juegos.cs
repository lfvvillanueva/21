using _21;

public class Juegos
{
    public static void Blackjack()
    {
        bool jugarDeNuevo = true;
        while (jugarDeNuevo)
        {
            Console.WriteLine("\n¡Bienvenido al juego de Blackjack contra la casa!\n");

            // Juego del jugador
            int playerTotal = Generar_Cartas.PlayHand("Jugador");

            // Verificar si el jugador ya perdió
            if (playerTotal > 21)
            {
                Console.WriteLine("Has perdido por pasarte de 21.");
                jugarDeNuevo = JugarDeNuevo();
                continue; // Continúa con el próximo juego si el jugador decide jugar de nuevo
            }

            // Juego de la casa
            Console.WriteLine("\nTurno de la casa:");
            int houseTotal = Generar_Cartas.PlayHand("Casa", 17); // La casa juega hasta que tenga al menos 17

            // Determinar el ganador
            if (houseTotal > 21 || playerTotal > houseTotal)
            {
                Console.WriteLine("¡Felicidades! Has ganado.");
            }
            else if (playerTotal == houseTotal)
            {
                Console.WriteLine("Es un empate.");
            }
            else
            {
                Console.WriteLine("La casa gana.");
            }

            jugarDeNuevo = JugarDeNuevo();
        }
    }

    private static bool JugarDeNuevo()
    {
        Console.Write("¿Quieres jugar de nuevo? (s/n): ");
        string respuesta = Console.ReadLine().Trim().ToLower();
        return respuesta == "s";
    }
}