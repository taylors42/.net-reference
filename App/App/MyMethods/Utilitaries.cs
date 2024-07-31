namespace App.MyMethods
{
    public class Utilitaries
    {
        public static Dictionary<string, List<int>> Bands = new Dictionary<string, List<int>>();
        public static void StartAppMessage(string ApresentationMessage)
        {
            Console.Clear();
            Console.WriteLine(ApresentationMessage);
        }
        public static void RegisterBand()
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
        public static void ShowAllBands()
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
                Thread.Sleep(1000);
                Console.WriteLine("\nPress enter to return to the menu options.");
                Console.ReadLine();
                Thread.Sleep(1000);
                Console.Clear();
                MenuOptions();
                return;
            }
        }
        public static string ShowMenuOptions(Dictionary<string, List<int>> UserDictionary)
        {
            string[] UserDictionaryKeys = new string[UserDictionary.Count];
            UserDictionary.Keys.CopyTo(UserDictionaryKeys, 0);
            int DictionaryIndex = 0;
            int DictionaryLength = UserDictionaryKeys.Length;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < UserDictionaryKeys.Length; i++)
                {
                    if (i == DictionaryIndex)
                    {
                        Console.Write("> ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(UserDictionaryKeys[i]);
                }
                ConsoleKeyInfo UserKey = Console.ReadKey();
                if (UserKey.Key == ConsoleKey.DownArrow)
                {
                    if(DictionaryIndex < DictionaryLength -1)
                    {
                        DictionaryIndex++;  
                    }
                    else
                    {
                        DictionaryIndex = 0;
                    }
                }
                else if (UserKey.Key == ConsoleKey.UpArrow)
                {
                    if(DictionaryIndex > 0)
                    {
                        DictionaryIndex--;
                    }
                    else
                    {
                        DictionaryIndex = DictionaryLength - 1;
                    }
                }
                else if (UserKey.Key == ConsoleKey.Enter)
                {
                    return UserDictionaryKeys[DictionaryIndex];
                }
                else
                {
                    return "Error";
                }
            }  
        }
        public static void ShowAverageRating()
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
                if (UserKey.Key == ConsoleKey.DownArrow)
                {
                    if(BandIndex < BandLength -1)
                    {
                        BandIndex++;  
                    }
                    else
                    {
                        BandIndex = 0;
                    }
                }
                else if (UserKey.Key == ConsoleKey.UpArrow)
                {
                    if(BandIndex > 0)
                    {
                        BandIndex--;
                    }
                    else
                    {
                        BandIndex = BandLength - 1;
                    }
                }
                else if (UserKey.Key == ConsoleKey.Enter)
                {
                    Console.Write($"The average rating of {BandKeys[BandIndex]} is {Bands[BandKeys[BandIndex]].Average()}");
                    Console.WriteLine("\nPress enter to return to the menu options.");
                    Console.ReadLine();
                    Thread.Sleep(1000);
                    Console.Clear();
                    MenuOptions();
                    return;
                }
                else
                {
                    Console.WriteLine("Exiting...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MenuOptions();
                    return;
                }
            }   
        }
        public static void RateBand(Dictionary<string, List<int>> Bands)
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
                if (UserKey.Key == ConsoleKey.DownArrow)
                {
                    if(BandIndex < BandLength -1)
                    {
                        BandIndex++;  
                    }
                    else
                    {
                        BandIndex = 0;
                    }
                }
                else if (UserKey.Key == ConsoleKey.UpArrow)
                {
                    if(BandIndex > 0)
                    {
                        BandIndex--;
                    }
                    else
                    {
                        BandIndex = BandLength - 1;
                    }
                }
                else if (UserKey.Key == ConsoleKey.Enter)
                {
                    Console.Write($"Write the rating for {BandKeys[BandIndex]}: ");
                    int UserRating = int.Parse(Console.ReadLine()!);
                    if (UserRating > 5 || UserRating < 1)
                    {
                        Console.WriteLine("Invalid rating. Please choose a number between 1 and 5.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        MenuOptions();
                        return;
                    }
                    Bands[BandKeys[BandIndex]].Add(UserRating);
                    Thread.Sleep(1000);
                    Console.Clear();
                    MenuOptions();
                    return;
                }
                else
                {
                    Console.WriteLine("Exiting...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MenuOptions();
                    return;
                }
            }   
        }
        public static void ExitApp()
        {
            Console.WriteLine("Bye!");
            Environment.Exit(0);
        }
        public static void GetUserInput(int UserOption)
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
                    ShowAverageRating();
                    break;

                case 5:
                    ExitApp();
                    break;
            }
        }
        public static void MenuOptions()
        {
            Console.Clear();
            Console.WriteLine("\nMenu options: ");
            Console.WriteLine("1. Register a band: ");
            Console.WriteLine("2. Show all bands: ");
            Console.WriteLine("3. Rate a band: ");
            Console.WriteLine("4. Show the average rating: ");
            Console.WriteLine("5. Exit: ");
            Console.Write("\nChoose an option: ");
            if (!int.TryParse(Console.ReadLine(), out int UserOption))
                {
                    Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
                    MenuOptions();
                    return;
                }
                else
                {
                    if (UserOption < 1 || UserOption > 5)
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
    }
}