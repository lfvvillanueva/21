using System;

namespace _21
{
    public class Generar_Cartas
    {
        static Random random = new Random();
        static string[] cards = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public static string GenerateCardValue()
        {
            int index = random.Next(cards.Length);
            return cards[index];
        }

        public static int PlayHand(string player, int stopAt = 21)
        {
            int total = 0;
            while (total < stopAt)
            {
                string card = GenerateCardValue();
                int cardValue = CardValue(card);
                total += cardValue;
                Console.WriteLine($"{player} sacó: {card} - Total actual: {total}");

                if (total >= 21 || (player == "Jugador" && total >= stopAt))
                    break;

                if (player == "Jugador")
                {
                    Console.Write("¿Deseas otra carta? (s/n): ");
                    if (Console.ReadLine().Trim().ToLower() != "s")
                        break;
                }
            }
            return total;
        }

        private static int CardValue(string card)
        {
            if (card == "A")
                return 11;  // Simplificación del As, podría necesitar lógica para alternar entre 1 y 11
            if (card == "J" || card == "Q" || card == "K")
                return 10;
            return int.Parse(card);
        }
    }
}