using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class MessageRepository : Repository<Message>, IMessageRepository
  {
    private readonly new RestDbContext _context;

    public MessageRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
