using static App.MyMethods.Utilitaries;
namespace App.Models
{
    class Music
    {
        public Music(Band SelfBand, string SelfName)
        {
            Artist = SelfBand.Name;
            Name = SelfName;
        }

        public string? Name { get; }
        public string? Artist { get; }
        private bool Available { get; set; }
        public int? Duration { get; set; }

        public void Slogan()
        {
            Console.WriteLine($"Thats a slogan! of the song: {Name} by the artist: {Artist}");
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Available: {(Available == true ? "Yes" : "No")}");
            Console.WriteLine($"Duration: {Duration}");
        }

        public void SetAvailable(bool Value)
        {
            Available = Value;
        }

        public bool GetAvailable()
        {
            return Available;
        }


    }
}
