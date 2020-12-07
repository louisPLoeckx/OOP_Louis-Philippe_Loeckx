using System;

namespace OOP_Louis_Philippe_Loeckx.Models
{
    public class Reis
    {
                
        public const double BasisDagPrijs = 40;

        private DateTime vertrekDatum;
        private DateTime terugkeerDatum;

        public int AantalDagen 
            {
            get { return (terugkeerDatum - vertrekDatum).Days; }
        }

        public int AantalPersonnen { get; set; }

        public DateTime TerugkeerDatum 
        {
            get {
                    return terugkeerDatum;
                }
            set {
                if (value > vertrekDatum)
                {
                    terugkeerDatum = value;
                }

            }
        }

        public DateTime VertrekDatum 
        {
            get
            {
                return vertrekDatum;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    vertrekDatum = value;
                }
                
            }
        }

        public virtual double BerekenPrijs()
        {
            return (AantalDagen * BasisDagPrijs);
        }

        public Reis(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum)
        {
            AantalPersonnen = aantalPersonen;
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
        }
    }
}
