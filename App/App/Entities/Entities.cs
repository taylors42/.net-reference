using System.Security.Cryptography.X509Certificates;

namespace App.Entities
{
    class Music
    {
        public Music(Band BandName) // thats a constructor
        {
            Name = BandName.Name;
        }
        public string? Name { get; set; }
        private string? Artist { get; set; }
        private bool Available { get; set; }
        public int? Duration { get; set; }
        // public string? Slogan => $"Thats a slogan! of the song: {Name} by the artist: {Artist}";

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
        
        public void SetArtist(Band BandName)
        {
            this.Artist = BandName.Name;
        }

        public string? GetArtist()
        {
            return this.Artist;
        }
    }

    class Album
    {
        private List<Music> MusicList = new List<Music>();
        public string? Name { get; set; }
        public int TotalDuration => MusicList.Sum(x => x.Duration ?? 0);
        public void AddMusic(Music Self)
        {
            MusicList.Add(Self);
        }
        public void ShowMusics()
        {
            Console.WriteLine("List of musics: \n");
            foreach (Music song in MusicList)
            {
                Console.WriteLine($"Song: {song.Name} - {song.GetArtist()}");
            }
            Console.WriteLine("\nTotal duration of the album: " + TotalDuration);
        }
    }

    class Band
    {
        private List<Album> AlbumList = new List<Album>();
        public string Name { get; set; }
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
    }

    class CodeMath
    {
        public int Add(int a, int b) => a + b; // Thats a example of a lambda function
    }  
}