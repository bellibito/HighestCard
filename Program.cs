using System;
using System.Threading;

namespace HighestCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = "";
            int playerCard = -1, compCard = -1;
            string playerCardn = "", compCardn = "";
            bool play = true;
            Deck newDeck = new Deck();

            Console.WriteLine("Please Enter Your Name");
            playerName = Console.ReadLine();

            while (play)
            {
                Console.WriteLine($"Lets Play Cards {playerName}!");

                Console.WriteLine($"{playerName}, press Enter to draw a card:");
                Console.ReadLine();
                Console.WriteLine("Shuffling...");
                Thread.Sleep(2000);
                newDeck.dealCard();
                playerCard = newDeck.getCard();
                playerCardn = newDeck.getCardName();
                Console.WriteLine($"{playerName} is dealt {playerCardn}\n");

                Console.WriteLine("I will now draw my card ");
                Console.WriteLine("Shuffling...");
                Thread.Sleep(2000);
                newDeck.dealCard();
                compCard = newDeck.getCard();
                compCardn = newDeck.getCardName();
                Console.WriteLine($"I am dealt {compCardn}\n");

                if (playerCard % 13 > compCard % 13)
                {
                    Console.WriteLine($"{playerName} wins with a {playerCardn}!\n\n");
                }
                else if (playerCard % 13 == compCard % 13)
                {
                    Console.WriteLine($"It's a draw! With a {playerCardn} and a {compCardn}!\n\n");
                }
                else
                {
                    Console.WriteLine($"I win with a {compCardn}!\n\n");
                }
          
                do
                {
                    Console.WriteLine("Would you like to play again?\nEnter 1 for YES, 2 for NO: ");
                    string choice = Console.ReadLine();
                    playerCard = Convert.ToInt32(choice);                  
                } while (playerCard < 1 || playerCard > 2);

                if(playerCard == 2)
                {
                    play = false;
                    Console.Clear();
                    Console.WriteLine("GoodBye");
                }
                else
                {
                    newDeck.newDeck();
                    Console.Clear();
                }
            }

        }


    }
}
