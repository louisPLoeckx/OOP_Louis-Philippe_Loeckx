using System;

namespace OOP_Louis_Philippe_Loeckx.Models
{
    class VliegtuigVakantie:Reis
    {
        private double VliegtuigTicketPrijs { get; set; }

        public override double BerekenPrijs()
        {
            return ((AantalDagen * BasisDagPrijs) + VliegtuigTicketPrijs);
        }
        public VliegtuigVakantie(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum): base(aantalPersonen, vertrekDatum, terugkeerDatum)
        {
            AantalPersonnen = aantalPersonen;
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
        }
    }
}
