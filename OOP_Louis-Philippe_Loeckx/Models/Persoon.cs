using System;

namespace OOP_Louis_Philippe_Loeckx.Models
{
    class Persoon
    {
        public Adres Adres { get; set; }
        public String FamilieNaam { get; set; }
        public String Naam { get { return $"{Voornaam} {FamilieNaam}"; } }
        public String Voornaam { get; set; }
    }
}
