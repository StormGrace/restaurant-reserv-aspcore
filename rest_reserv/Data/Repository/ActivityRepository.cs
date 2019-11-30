using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class ActivityRepository : Repository<Activity>, IActivityRepository
  {
    private readonly new RestDbContext _context;

    public ActivityRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
