using static App.MyMethods.Utilitaries;
namespace App.Models
{
    class Band
    {
        public Band(string Self)
        {
            Name = Self;
        }

        private List<Album> AlbumList = new List<Album>();

        public string? Name { get; }

        public void AddAlbum(Album album)
        {
            AlbumList.Add(album);
        }

        public void ShowAlbuns()
        {
            Console.WriteLine($"List of albums from: {Name}");
            foreach (Album item in AlbumList)
            {
                Console.WriteLine($"Album: {item.Name} - Duration: {item.TotalDuration}");
            }
        }

        public static void RegisterBand()
        {
            Console.Clear();
            Console.Write("Register a band name: ");
            Band BandToRegister = new Band(Console.ReadLine()!);
            Thread.Sleep(1000);
            Console.WriteLine($"Band {BandToRegister.Name} registered successfully!");
            Thread.Sleep(1000);
            Console.Clear();
            MenuOptions();
        }
    }
}
