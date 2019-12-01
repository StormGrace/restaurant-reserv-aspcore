using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;
using System.Linq;

namespace rest_reserv.Data.Repository
{
  public class ListingRepository : Repository<Listing>, IListingRepository
  {
    private readonly new RestDbContext _context;
    private ListingLogRepository _listingLogRepository;

    public ListingRepository(RestDbContext context, ListingLogRepository listingLogRepository) : base(context)
    {
      _context = context;
      _listingLogRepository = listingLogRepository;
    }

    public Listing FindById(int id)
    {
      return FindFirst(listing => listing.ListingId.Equals(id));
    }
    
   /* public Listing FindLatestByName(string name)
    {
      ListingLog listingLog = _listingLogRepository.FindLatestByName(name);

      return FindFirst(listing => listing.ListingLog.Contains(listingLog));
    }*/
  }
}
