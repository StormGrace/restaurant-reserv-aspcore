using rest_reserv.Data.Model;
using rest_reserv.Data.Repository.Interface.Common;


namespace rest_reserv.Data.Repository.Interface
{
  public interface IListingLogRepository : IRepository<ListingLog>, ILogRepository<ListingLog>
  {

  }
}
