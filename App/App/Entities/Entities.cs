class Music
{
    public Music(Band SelfBand, string SelfName) // thats a constructor
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
}

class CodeMath
{
    public int Add(int a, int b) => a + b; // Thats a example of a lambda function
}

class Podcast
{
    public Podcast(string PodcastName, string PodcastHost)
    {
        Name = PodcastName;
        Host = PodcastHost;
    }

    public string? Name { get; }
    public string? Host { get; }
    public int TotalEpisodes()
    {
        return
    }

}

class EpisodePodcast
{
    private List<string> Members = new List<string>();
    public EpisodePodcast(string? Title, float Duration, string Podcast)
    {
        Title = Title;
        Duration = Duration;
    }

    public void AddMembers(string Member)
    {
        Members.Add(Member);
    }
    public string Title { get; }
    public float Duration { get; }
}
