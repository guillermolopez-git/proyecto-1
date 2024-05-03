namespace CodexApp.Models.Events
{
    public class PinUpdateEvent: EventArgs
    {
        public int Pin { get; set; }
        public int UpdatedPin { get; set; }
    }
}
