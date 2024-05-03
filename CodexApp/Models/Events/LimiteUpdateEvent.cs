namespace CodexApp.Models.Events
{
    public class LimiteUpdateEvent: EventArgs // eventargs : clase base para clases que contienen datos de eventos
    {
        public int Pin { get; set; }

        public int UpdatedLimite { get; set; }
    }
}
