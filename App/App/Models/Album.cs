namespace App.Models
{
    class Album
    {
        public Album(string Self)
        {
            Name = Self;
        }

        private List<Music> MusicList = new List<Music>();
        public string Name { get; }
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
                Console.WriteLine($"Song: {song.Name} - {song.Artist}");
            }
            Console.WriteLine("\nTotal duration of the album: " + TotalDuration);
        }
    }
}