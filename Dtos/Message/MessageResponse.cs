namespace chat_sample.Dtos.Message
{
    public class MessageResponse
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
