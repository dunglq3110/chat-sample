namespace chat_sample.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string Content { get; set; } = "";
    }
}
