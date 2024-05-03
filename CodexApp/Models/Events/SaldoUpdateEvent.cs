namespace CodexApp.Models.Events
{
    public class SaldoUpdateEvent : EventArgs
    {
        public int Pin { get; set; }

        public decimal UpdatedSaldo { get; set; }

       
    }
}
