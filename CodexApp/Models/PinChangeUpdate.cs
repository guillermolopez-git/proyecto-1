namespace CodexApp.Models
{
    public class PinChangeUpdate
    {
        public int Pin { get; set; }
        public int UpdatedPin { get; set; }

        public PinChangeUpdate(int pin, int updatedPin)
        {
            Pin = pin;
            UpdatedPin = updatedPin;
        }
    }
}
