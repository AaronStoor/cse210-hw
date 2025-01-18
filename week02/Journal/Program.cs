using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine($"Journal Menu: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string entryText = Console.ReadLine();

                    journal.AddEntry(date, prompt, entryText);
                    Console.WriteLine("Entry saved!\n");
                    break;
                case "2":
                    journal.DisplayAllEntries();
                    break;
                case "3":
                Console.Write("Enter filename to load journal: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                    
                case "4":
                    Console.Write("Enter filename to save journal: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Exiting the journal program...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option");
                    break;
            }
            
        }
    }
}