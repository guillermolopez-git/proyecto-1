namespace CodexApp.Models
{
    public class PinNode
    {
        public PinChangeUpdate? Data { get; set; }
        public PinNode? Next { get; set; }

        public PinNode(PinChangeUpdate data)
        {
            Data = data;
            Next = null;
        }

    }
}
