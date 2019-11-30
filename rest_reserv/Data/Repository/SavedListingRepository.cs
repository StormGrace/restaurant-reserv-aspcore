using Microsoft.EntityFrameworkCore;
using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface;

namespace rest_reserv.Data.Repository
{
  public class SavedListingRepository : Repository<SavedListing>, ISavedListingRepository
  {
    private readonly new RestDbContext _context;

    public SavedListingRepository(RestDbContext context) : base(context)
    {
      _context = context;
    }
  }
}
