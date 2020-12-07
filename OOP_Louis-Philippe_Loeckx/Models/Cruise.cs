using System;

namespace OOP_Louis_Philippe_Loeckx.Models
{
    public class Cruise:Reis
    {
        public const int CruisPrijsExtraDagKost = 10;

        private bool VIP { get; set; }//Can only be used in this class

        public override double BerekenPrijs()
        {
            if (VIP)
            {
                return (AantalDagen * CruisPrijsExtraDagKost) * 1.5;
            }
            else
            {
                return AantalDagen * CruisPrijsExtraDagKost;
            }
            
        }

        public Cruise(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum):base(aantalPersonen,vertrekDatum,terugkeerDatum)
        {
            AantalPersonnen = aantalPersonen;
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
        }
        
    }
}
