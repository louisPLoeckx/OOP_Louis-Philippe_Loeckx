
namespace OOP_Louis_Philippe_Loeckx.Models
{
    class Persoon
    {
        public Adres Adres { get; set; }
        public string Naam { get { return $"{Voornaam} {FamilieNaam}"; } }
        public string Voornaam { get; set; }
        public string FamilieNaam { get; set; }
    }
}
