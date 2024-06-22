using chat_sample.Dtos.Message;

namespace chat_sample.Services
{
    public interface IMessageService
    {
        Task<IEnumerable<MessageResponse>> GetAllMessageAsync();
        Task<MessageResponse> InsertMessage(MessageSendRequest messageSendRequest); 
    }
}
