using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entrytext = response;

                journal.AddEntry(entry);

                Console.WriteLine("Entry added to journal succesfully");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename");
                string filename = Console.ReadLine();
                
                if (File.Exists(filename))
                {
                    journal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded successfully");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully");
            }
            else if (choice == "5")
            {
                Console.Write("Enter keyword to search: ");
                string keyword = Console.ReadLine();
                journal.SearchEntries(keyword);
            }
            else if (choice == "6")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
            
        }
    }
}