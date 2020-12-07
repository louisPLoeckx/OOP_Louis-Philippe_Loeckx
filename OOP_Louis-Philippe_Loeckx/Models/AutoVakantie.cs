using System;

namespace OOP_Louis_Philippe_Loeckx.Models
{
    public class AutoVakantie:Reis
    {
        public const int ExtraPrijsHuurAuto = 10;

        private bool EigenWagen { get; set; }

        public override double BerekenPrijs()
        {
            if (EigenWagen)
            {
                return (AantalDagen * BasisDagPrijs);
            }
            else
            {
                if (AantalPersonnen>5)
                {
                    int numberOfVehicles = AantalPersonnen / 5;
                    if ((numberOfVehicles % 5) == 0)
                    {
                        return ((AantalDagen * BasisDagPrijs) * ((ExtraPrijsHuurAuto) * numberOfVehicles));
                    }
                    else
                    {
                        return ((AantalDagen * BasisDagPrijs) * ((ExtraPrijsHuurAuto + 1) * numberOfVehicles));
                    }
                }
                else
                {
                    return ((AantalDagen * BasisDagPrijs) * ExtraPrijsHuurAuto);
                }
            }
        }

        public AutoVakantie(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum):base(aantalPersonen, vertrekDatum, terugkeerDatum)
        {
            AantalPersonnen = aantalPersonen;
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
        }
    }
}
