using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class UserRepository : Repository<User>, IUserRepository
  {
    private readonly new RestDbContext _context;

    public UserRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
