using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class ListingRepository : Repository<Listing>, IListingRepository
  {
    private readonly new RestDbContext _context;

    public ListingRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
