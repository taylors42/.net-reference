namespace App.Entities
{
    class Music
    {
        public string? Name { get; set; }
        public string? Artist { get; set; }
        private bool Available { get; set; }
        public int? Duration { get; set; }

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