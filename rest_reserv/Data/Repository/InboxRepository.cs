using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class InboxRepository : Repository<Inbox>, IInboxRepository
  {
    private readonly new RestDbContext _context;

    public InboxRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
