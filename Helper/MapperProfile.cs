using AutoMapper;
using chat_sample.Dtos.Message;
using chat_sample.Models;

namespace chat_sample.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<MessageSendRequest, Message>();
            CreateMap<Message, MessageResponse>();
        }
    }
}
