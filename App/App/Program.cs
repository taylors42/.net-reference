using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata;
using static App.MyMethods.Utilitaries;
using Entities;
using App.Models;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Clear();
            // StartAppMessage("Welcome to the band manager!");
            // Album Metallica = new Album();
            // Metallica.Name = "Master Of Puppets";
            // Music Battery = new Music();
            // Music NothingElseMatters = new Music();
            // NothingElseMatters.Artist = "Metallica";
            // NothingElseMatters.Name = "Nothing Else Matters";
            // NothingElseMatters.Duration = 200;
            // Metallica.AddMusic(NothingElseMatters);
            
            // Battery.Artist = "Metallica";
            // Battery.Name = "Battery";
            // Battery.Duration = 120;
            // Metallica.AddMusic(Battery);
            // Metallica.ShowMusics();
            // Console.WriteLine(Battery.Slogan);

            Band BlueOysterCult = new Band("Blue Oyster Cult");

            Music TheReaper = new Music(BlueOysterCult, "");
            TheReaper.Name = "The Reaper";
            TheReaper.Duration = 200;

            TheReaper.ShowDetails();



            Console.ReadLine();
        }
    }
}

