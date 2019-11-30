using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class ReviewActivityRepository : Repository<ReviewActivity>, IReviewActivityRepository
  {
    private readonly new RestDbContext _context;

    public ReviewActivityRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
