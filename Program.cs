using System;

namespace WordleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }

        }
        public static void TestAll()
        {
            bool testDisplayInfo = TestDisplayInfo.RunTest();
            Console.WriteLine($"Test LoadFile(filename): {testDisplayInfo}");

            bool testDisplayCharInfo = TestDisplayCharInfo.RunTest();
            Console.WriteLine($"Test LoadFile(filename): {testDisplayCharInfo}");

            bool testGetGuess = TestGetGuess.RunTest();
            Console.WriteLine($"Test LoadFile(filename): {testGetGuess}");

            bool testGetRandomWord = TestGetRandomWord.RunTest();
            Console.WriteLine($"Test LoadFile(filename): {testGetRandomWord}");



            
        }
        /// <summary>
        /// It will generate a random word then returns it.
        /// </summary>
        /// <returns>a random word</returns>
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
        /// Given a guess checks the guess whether or not the guess has the right number of letters for the word
        /// </summary>
        /// <param name="correctWord"></param>
        /// <returns>either error if the word isn't the right size or feedback on the guess</returns>
        public static string GetGuess(string correctWord)
        {
            // 1. Prompt the user to make a guess
            // 2. Read input from the keyboard and store the results in a variable named guess
            // 3. If guess is the correct length (the guess and random word should be the same length), return the guess.
            // Otherwise, display an error message and ask them to make another guess.
            return null;
        }
        /// <summary>
        /// Check if the guess is the right length and if not throw an exception and if they do use the next variable to determine the validity of the guess.
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="correct"></param>

        public static void DisplayInfo(string guess, string correct)
        {
            // 1. Validate that the guess and correct word are the same length
            // 2. If the lengths do not match, throw an exception
            // 3. If they match, iterate through each character:
            // Use the DisplayCharInfo method to determine what color to print the character
        }
        /// <summary>
        /// Use green when the letter is correct and in the right position from the input, use yellow if the letter is in the word but in the wrong position, and use red if it is not in the word at all.
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="pos"></param>
        /// <param name="correct"></param>
        public static void DisplayCharInfo(char guess, int pos, string correct)
        {
            // 1. If the guess is in the correct position, select the color green.
            // 2. If the guess is in the correct word but not correct position, select yellow.
            // 3. If the guess is not in the correct word, select red.
            // 4. Display the guess
            // 5. Reset the color back to white before returning

        }
    }
}
