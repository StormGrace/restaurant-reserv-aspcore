using System;
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
        public JsonResult GetListings()
        {
          /*List<Listing> listings = new List<Listing>();

          for(int i = 0; i < 134; i++)
          {
            listings.Add(new Listing("Placeholder Title " + (i + 1)));
          }

          return new JsonResult(listings);
       
          */

          //DB Fetch.
          return new JsonResult(_listingLogRepository.FindAllLatest());
        }

        [HttpGet]
        public JsonResult GetListing(string name)
        {
          return new JsonResult(_listingLogRepository.FindLatestByName(name));
        }
    }

    public class Listing
    {
      public string listingTitle { get; set; }
      public string listingImgPath { get; set; }
      public int listingReviewCount { get; set; }     
      public float rating { get; set; }

      public Listing(string providedListingTitle)
      {
        Random rand = new Random();

        listingTitle = providedListingTitle;
        listingImgPath = "rest-1.jpg";
        //listingReviewCount = rand.Next(0, 230);
        listingReviewCount = 0;
        rating = 0.2f;
      }
    }
}