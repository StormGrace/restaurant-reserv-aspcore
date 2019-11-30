using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class MessageTypeRepository : Repository<MessageType>, IMessageTypeRepository
  {
    private readonly new RestDbContext _context;

    public MessageTypeRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
