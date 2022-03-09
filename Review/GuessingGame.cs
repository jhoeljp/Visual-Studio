//using System;
//namespace Hippo
//{
//    //public class GuessingGame
//    class GuessingGame
//    {
//        //public GuessingGame()
//        static void Main(string[] args)
//        {
//            string secretWord = "Hippo";
//            string guess;
//            int guessCount = 0;
//            int guessLimit = 3;
//            bool youWin = false;

//            do
//            {
//                guessCount++;
//                Console.WriteLine("Enter your guess word: ");
//                guess = Console.ReadLine();
//                Console.WriteLine(guessCount);

//                if (guess.ToLower() == secretWord.ToLower())
//                {
//                    youWin = true;
//                }
                

//            } while (!youWin && guessLimit > guessCount);

//            if (youWin) { Console.WriteLine("You win! "); }
//            else { Console.WriteLine("You Lose Loser! "); }
//        }
//    }
//}
