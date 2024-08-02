using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata;
using static App.MyMethods.Utilitaries;
using App.Entities;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            StartAppMessage("Welcome to the band manager!");

            // Instance of the Music class
            Music myBand = new Music();
            myBand.Name = "Metallica";
            Console.WriteLine(myBand.Name);
            Console.ReadLine();
            MenuOptions();
        }
    }
}

