using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class ListingLogRepository : Repository<ListingLog>, IListingLogRepository
  {
    private readonly new RestDbContext _context;

    public ListingLogRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
