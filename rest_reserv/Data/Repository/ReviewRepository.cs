using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class ReviewRepository : Repository<Review>, IReviewRepository
  {
    private readonly new RestDbContext _context;

    public ReviewRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
