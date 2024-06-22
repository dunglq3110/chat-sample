using AutoMapper;
using chat_sample.Dtos.Message;
using chat_sample.Models;
using chat_sample.Repositories;

namespace chat_sample.Services.Impl
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IMapper mapper;

        public MessageService(IMessageRepository messageRepository, IMapper mapper)
        {
            _messageRepository = messageRepository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<MessageResponse>> GetAllMessageAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<MessageResponse> InsertMessage(MessageSendRequest messageSendRequest)
        {
            var message = await _messageRepository.AddAsync(mapper.Map<Message>(messageSendRequest));
            return mapper.Map<MessageResponse>(message);
        }
    }
}
