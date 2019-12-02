using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface.Common;
using System.Collections.Generic;

namespace rest_reserv.Data.Repository.Interface
{
  public interface IListingLogRepository : IRepository<ListingLog>, ILogRepository<ListingLog>
  {
    public ListingLog FindLatestById(int id);

    public ListingLog FindLatestByName(string name);

    public IEnumerable<ListingLog> FindAllById(int id);

    public IEnumerable<ListingLog> FindAllByName(string name);

    public IEnumerable<ListingLog> FindAllLatest();
  }
}
