using System;
using System.Collections.Generic;

namespace ScriptureApp  
{
    class Program
    {
        static void Main()
        {
            Reference reference = new Reference("John", 3, 16);

            string scriptureText = "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.";
            Scripture scripture = new Scripture(reference, scriptureText);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            while (true)
            {
                Console.WriteLine("\nPress Enter to hide a random word, or type 'quit' to exit.");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(1);

                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Exiting the program.");
                    break;
                }
            }
        }
    }
}
