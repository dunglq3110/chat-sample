namespace chat_sample.Dtos.Message
{
    public class MessageSendRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public MessageSendRequest(string username, string content)
        {
            Username = username;
            Content = content;
        }
    }
}
