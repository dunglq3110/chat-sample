using chat_sample.Data;
using chat_sample.Models;

namespace chat_sample.Repositories.Impl
{
    public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
        public MessageRepository(AppDbContext _con) : base(_con)
        {
        }
    }
}
