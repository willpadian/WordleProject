using System;

namespace WordleProject
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetRandomWord()
        {
            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correctWord"></param>
        /// <returns></returns>
        string GetGuess(string correctWord)
        {
            // 1. Prompt the user to make a guess
            // 2. Read input from the keyboard and store the results in a variable named guess
            // 3. If guess is the correct length (the guess and random word should be the same length), return the guess.
            // Otherwise, display an error message and ask them to make another guess.
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="correct"></param>

        void DisplayInfo(string guess, string correct)
        {
            // 1. Validate that the guess and correct word are the same length
            // 2. If the lengths do not match, throw an exception
            // 3. If they match, iterate through each character:
            // Use the DisplayCharInfo method to determine what color to print the character
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="pos"></param>
        /// <param name="correct"></param>
        void DisplayCharInfo(char guess, int pos, string correct)
        {
            // 1. If the guess is in the correct position, select the color green.
            // 2. If the guess is in the correct word but not correct position, select yellow.
            // 3. If the guess is not in the correct word, select red.
            // 4. Display the guess
            // 5. Reset the color back to white before returning

        }
    }
}
