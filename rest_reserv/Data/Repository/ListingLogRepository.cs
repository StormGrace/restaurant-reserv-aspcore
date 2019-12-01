using System.Collections.Generic;
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

    public ListingLog FindLatestById(int id)
    {
      return FindLast(listing => listing.ListingId.Equals(id));
    }

    public ListingLog FindLatestByName(string name)
    {
      return FindLast(listing => listing.ListingTitle.ToLower().Replace(' ', '-').Equals(name));
    }

    public IEnumerable<ListingLog> FindAllById(int id)
    {
      return Find(listing => listing.ListingId.Equals(id));
    }

    public IEnumerable<ListingLog> FindAllByName(string name)
    {
      return Find(listing => listing.ListingTitle.ToLower().Replace(' ', '-').Equals(name));
    }
  }
}
