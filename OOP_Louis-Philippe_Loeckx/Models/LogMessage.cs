using System;
using System.Linq;

namespace OOP_Louis_Philippe_Loeckx.Models
{
    public class LogMessage
    {
        private string Boodschap { get; set; }
        private int[] IDs = new int[0];
        private int ID 
        {
            get { return ID; }
            set
            {
                if (IDs.Length == 0)
                {
                    ID = 0;
                    IDs[0] = ID;
                    Array.Resize(ref IDs, ID);
                }
                else
                {
                    ID = GenereerID(IDs);
                    Array.Resize(ref IDs, ID);
                    IDs.Append(ID);
                }
                
            }
        }

        static int GenereerID(int[] IDs)
        {
            if (IDs.Length == 0)
            {
                return 0;
            }
            else
            {
                int ID = IDs.Max() + 1;
                return ID;
            }
            
        }

        public LogMessage(string boodschap)
        {
            this.Boodschap = boodschap;

        }
    }
}
