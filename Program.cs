using System.Reflection.Metadata.Ecma335;

namespace Wordle
{
	class Program
	{
		static void Main(string[] arg)
		{
			Start();

			static void Start()
			{
				Console.WriteLine("Douglas's Wordle");
				Console.WriteLine("1 - Play");
				Console.WriteLine("0 - Exit");

				String choice = Console.ReadLine() ?? ""; // [?? ""] removes the null warning.

				if (choice.Equals("1"))
				{
					Console.Clear();
					Play();
				}
				else if (choice.Equals("0"))
				{
					Console.Clear();
					Console.WriteLine("Goodbye!");
					Exit();
				}
				else
				{
					Console.WriteLine("Hey");
				}

			}
		}
		static void Exit()
		{
			Environment.Exit(1);
		}

		static void Play()
		{
			// QUICK REMINDERS FOR MYSELF:
			// Wordle consists of a maximum of 6 guesses
			// 5 letter word (normal)
			// Green if letter is INSIDE the word AND in the correct position
			// Yellow if letter is INSIDE the word but NOT in the correct position
			// Grey if letter is NOT inside the word at all
			// There can be multiple instances of a single letter, which I'll have to work out at some point

			// For now the Answer will always be "s t o a t" to work out the logic
			char[] answer = {'s','t','o','a','t'};
			
			Console.WriteLine("Please type in a five letter word and press ENTER");
			
			String guess = Console.ReadLine()  ?? "";
			char[] validGuess = GuessCheck(guess);

			Console.WriteLine("Making sure the array is correct:");
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(validGuess[i]);
			}


		}

		static char[] GuessCheck(String guess)
		{
			char[] validGuess = {};

			if (guess.Length == 5)
			{
				Console.WriteLine($"Yeah that works: {guess}");
                validGuess = guess.ToCharArray();
            }
			else 
			{
				Console.WriteLine($"Your guess was {guess.Length} characters long.");
				Console.WriteLine("Guesses must be five characters long");
			}
			return validGuess;
        }

		static void Respond(char[] vg, char[] answer)
		{

		}
	}
}