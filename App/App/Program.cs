using System.Diagnostics;
using System.Reflection.Metadata;

Dictionary<string, List<int>> Bands = new Dictionary<string, List<int>>();
Bands.Add("ACDC", new List<int>{10});
Bands.Add("Opeh", new List<int>{10});
void MainFunction()
{
    Console.Clear();
    StartAppMessage("Welcome to the band manager!");
    MenuOptions();
}

void StartAppMessage(string ApresentationMessage)
{
    Console.Clear();
    Console.WriteLine(ApresentationMessage);
}

void RegisterBand()
{
    Console.Clear();
    Console.Write("Register a band name: ");
    string BandName = Console.ReadLine()!;
    Bands.Add(BandName, new List<int>());
    Thread.Sleep(1000);
    Console.WriteLine($"Band {BandName} registered successfully!");
    Thread.Sleep(1000);
    Console.Clear();
    MenuOptions();
}

void ShowAllBands()
{

    Console.Clear();
    if (Bands.Count == 0)
    {
        Console.WriteLine("There are no bands registered.");
        Thread.Sleep(1000);
        Console.Clear();
        MenuOptions();
    }
    else 
    {
        foreach (string Band in Bands.Keys)
        {
            Thread.Sleep(250);
            Console.WriteLine($"Band: {Band}");
        }
        Console.WriteLine("Press enter to return to the menu options.");
        Console.ReadLine();
        Thread.Sleep(1000);
        Console.Clear();
        return;
    }
}

void SearchBand()
{

}

void ShowAverageRating()
{

}
void RateBand(Dictionary<string, List<int>> Bands)
{
    string[] BandKeys = new string[Bands.Count];
    Bands.Keys.CopyTo(BandKeys, 0);
    int BandIndex = 0;
    int BandLength = BandKeys.Length;
    while (true)
    {
        Console.Clear();
        for (int i = 0; i < BandKeys.Length; i++)
        {
            if (i == BandIndex)
            {
                Console.Write("> ");
            }
            else
            {
                Console.Write("  ");
            }
            Console.WriteLine(BandKeys[i]);
        }
        ConsoleKeyInfo UserKey = Console.ReadKey();
        if (UserKey.Key == ConsoleKey.DownArrow && BandIndex > 1)
        {
            BandIndex--;  
        }
        else if (UserKey.Key == ConsoleKey.UpArrow && BandIndex < BandLength)
        {
            BandIndex++;
        }
        else if (UserKey.Key == ConsoleKey.Enter)
        {
            Console.WriteLine($"Write the rating for {BandKeys[BandIndex]}: ");
            int UserRating = int.Parse(Console.ReadLine()!);
            Bands[BandKeys[BandIndex]].Add(UserRating);
            return;
        }
    }   
}
void ExitApp()
{
    Console.WriteLine("Bye!");
}

void MenuOptions()
{
    Console.Clear();
    Console.WriteLine("\nMenu options: ");
    Console.WriteLine("1. Register a band: ");
    Console.WriteLine("2. Show all bands: ");
    Console.WriteLine("3. Rate a band: ");
    Console.WriteLine("4. Search a band: ");
    Console.WriteLine("5. Show the average rating: ");
    Console.WriteLine("6. Exit: ");
    Console.Write("\nChoose an option: ");
    if (!int.TryParse(Console.ReadLine(), out int UserOption))
    {
        Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
        MenuOptions();
        return;
    }
    else
    {
        if (UserOption < 1 || UserOption > 6)
        {
            Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
            MenuOptions();
            return;
        }
        else
        {
            GetUserInput(UserOption);
        }
    }
}

void GetUserInput(int UserOption)
{
    switch (UserOption)
    {
        case 1:
            RegisterBand();
            break;

        case 2:
            ShowAllBands();
            break;
        
        case 3:
            RateBand(Bands);
            break;

        case 4:
            SearchBand();
            break;

        case 5:
            ShowAverageRating();
            break;

        case 6:
            ExitApp();
            break;
    }
}

MainFunction();
