// Showing Creativity and Exceeding Requirements:
// Load reference and scripture from file.
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string filePath = "scripture.txt";
        var result = LoadFromFile(filePath);

        Reference reference = new Reference(result.book, result.chapter, result.startVerse, result.endVerse);
        Scripture scripture = new Scripture(reference, result.scripture);
        string response = "";
        // While loop and if statement 
        while (response?.ToLower() != "quit")
        {
            // Display reference 
            Console.Write(reference.GetDisplayText());
            // Display scripture
            Console.WriteLine(scripture.GetDisplayText());
            // Check if all words are hidden. If yes, quit.
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            // Prompt user to press enter or quit
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();

            if (response?.ToLower() != "quit")
            {
                // Clear the console screen
                Console.Clear();
                // Hide 3 random words
                int number = 3; 
                scripture.HideRandomWords(number);
            }
        }
        Console.WriteLine("Program ended. Goodbye.");
    }
    static (string book, int chapter, int startVerse, int endVerse, string scripture) LoadFromFile(string filePath)
    {
        Console.WriteLine("Reading scripture from file...");

        string[] lines = System.IO.File.ReadAllLines(filePath);
        // First line in the file is a comment
        string book = lines[1];
        int chapter = int.Parse(lines[2]);
        int startVerse = int.Parse(lines[3]);
        int endVerse = int.Parse(lines[4]);
        string scripture = lines[5];
        return (book, chapter, startVerse, endVerse, scripture);
    }
}
