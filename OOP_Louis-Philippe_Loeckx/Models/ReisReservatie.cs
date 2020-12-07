

namespace OOP_Louis_Philippe_Loeckx.Models
{
    class ReisReservatie
    {
        public LogMessage LogMessage { get; set; }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public ReisBureau ReisBureau { get; set; }

        public ReisReservatie()
        {
            LoggerService.AddLogMessage(LogMessage);
        }
    }
}
