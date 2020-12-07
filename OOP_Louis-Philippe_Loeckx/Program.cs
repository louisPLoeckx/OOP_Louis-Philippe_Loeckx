using OOP_Louis_Philippe_Loeckx.Models;
using System;

namespace OOP_Louis_Philippe_Loeckx
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon Francko = new Persoon();
            Francko.Voornaam = "James";
            Francko.FamilieNaam = "Francko";

            Adres AdresTui = new Adres();
            AdresTui.Gemeente = "Lot";
            AdresTui.HuisNr = "1";
            AdresTui.Zipcode = 0001;
            AdresTui.Straat = "Steenweg Brussel";

            ReisBureau TUI = new ReisBureau();
            TUI.Adres = AdresTui;
            TUI.Naam = "TUI";


            DateTime departureDate = new DateTime(2020, 12, 12);
            DateTime ReturnDate = new DateTime(2020, 12, 20);
            AutoVakantie Trip = new AutoVakantie(8, departureDate, ReturnDate);
            
            ReisReservatie first = new ReisReservatie() ;
            first.Persoon = Francko;
            first.ReisBureau = TUI;
            first.Reis = Trip;

            Console.WriteLine(first.Reis.BerekenPrijs());
            Console.WriteLine(first.Reis.AantalDagen);


        }
    }
}
