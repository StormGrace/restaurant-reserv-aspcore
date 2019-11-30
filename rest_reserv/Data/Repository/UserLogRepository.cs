using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class UserLogRepository : Repository<UserLog>, IUserLogRepository
  {
    private readonly new RestDbContext _context;

    public UserLogRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
