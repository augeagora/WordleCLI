using System.Drawing;

namespace Wordle
{
    class Program
    {
        public static class GlobalVariables
        {
            public static bool[] correctGuess = new bool[5];
        }
        static void Main(string[] arg)
        {
            Boot();
            // Start();
            PlayNormal();
        }

        static void Boot()
        {
            String aa = "AugeAgora";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 9; i++)
            {
                Console.Write(aa[i]);
                Thread.Sleep(100);
            }
            Thread.Sleep(200);
            Console.ResetColor();
            Console.Clear();
        }

        static void PlayNormal()
        {
            char[] answer = { 's', 't', 'o', 'a', 't' };

            // Make sure guess is five letters long
            String guess = CheckGuess();
            char[] guessArray = guess.ToCharArray();

            // Determine what characters in the guess
            // appear more than once.
            CheckRepeats(guess, guessArray, answer);
        }

        static string CheckGuess()
        {
            String guess = "";

            while (guess.Length != 5)
            {
                Console.Write("Type in your Guess: ");
                guess = Console.ReadLine();
                guess = guess.ToLower();

                if (guess.Length != 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Guess must be five letters");
                    Console.ResetColor();
                }
            }
            return guess;
        }

        static void CheckRepeats(String guess, char[] guessArray, char[] answer)
        {

        }
	}
}