namespace CodexApp.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string? Message { get; set; }

        public Notification(int id, string message)
        {
            Id = id;
            Message = message;
        }
    }
}
