using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {

        // I made a list of scriptures one from each of the stadard works
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life."),
            new Scripture(new Reference("Isaiah", 53, 4, 5), "Surely he hath borne our griefs, and carried our sorrows: yet we did esteem him stricken, smitten of God, and afflicted. 5. But he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our peace was upon him; and with his stripes we are healed."),
            new Scripture(new Reference("Alma", 34, 10), "For it is expedient that there should be a great and last sacrifice; yea, not a sacrifice of man, neither of beast, neither of any manner of fowl; for it shall not be a human sacrifice; but it must be an infinite and eternal sacrifice."),
            new Scripture(new Reference("Doctrine & Covenants", 61, 2), "Behold, verily thus saith the Lord unto you, O ye elders of my church, who are assembled upon this spot, whose sins are now forgiven you, for I, the Lord, forgive sins, and am merciful unto those who confess their sins with humble hearts;"),
            new Scripture(new Reference("Moses", 6, 61), "Therefore it is given to abide in you; the record of heaven; the Comforter; the peaceable things of immortal glory; the truth of all things; that which quickeneth all things, which maketh alive all things; that which knoweth all things, and hath all power according to wisdom, mercy, truth, justice, and judgment.")
        };

        Random rand = new Random();
        int randomIndex = rand.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[randomIndex];

        Console.Clear();
        Console.WriteLine("Selected Scripture: ");
        Console.WriteLine(selectedScripture.GetDisplayText());

        while (true)
        {
            // I also made the program to ask the user how many words they want to hide
            Console.WriteLine("\nHow many words would you like to hide? ");
            string input = Console.ReadLine().Trim().ToLower();
            

            if (input == "quit")
            {
                break;
            }

            int numberToHide;
            if (int.TryParse(input, out numberToHide) && numberToHide > 0)
            {
                selectedScripture.HideRandomWords(numberToHide);

                Console.Clear();
                Console.WriteLine("Selected Scripture: ");
                Console.WriteLine(selectedScripture.GetDisplayText());
            }
            else
            {
                Console.WriteLine("Please enter a valid number greater than 0. ");
            }

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Exiting the program. ");
                break;
            }

            
        }
    }
}
