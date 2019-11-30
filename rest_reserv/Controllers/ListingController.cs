using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rest_reserv.Data.Repository.Interface;


namespace rest_reserv.Controllers
{
    public class ListingController : ControllerBase
    {
        private IListingLogRepository _listingLogRepository;
      
        public ListingController(IListingLogRepository listingLogRepository)
        {
           _listingLogRepository = listingLogRepository;
        }

        [HttpGet]
        public JsonResult GetAllListings()
        {
          List<Listing> listings = new List<Listing>();

          for(int i = 0; i < 134; i++)
          {
            listings.Add(new Listing("Placeholder Title " + (i + 1)));
          }

          return new JsonResult(listings);
        }
    }

    public class Listing
    {
      public string listingTitle { get; set; }
      public string listingImgPath { get; set; }

      public Listing(string providedListingTitle)
      {
        listingTitle = providedListingTitle;
        listingImgPath = "rest-1.jpg";
      }
    }
}