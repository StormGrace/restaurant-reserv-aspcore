using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class ActivityTypeRepository : Repository<ActivityType>, IActivityTypeRepository
  {
    private readonly new RestDbContext _context;

    public ActivityTypeRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
