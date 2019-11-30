import { Component, OnInit } from '@angular/core';

import { ListingService, Listing } from '../../services/listing.service';

@Component({
  selector: "ListingGallery",
  templateUrl: "./listing-gallery.component.html",
  styleUrls: ["./listing-gallery.component.scss"]
})
export class ListingGalleryComponent implements OnInit {

  public listings: Listing[];

  public listingsPerPage: number = 10; //Even Number.

  public listingPages: number[];

  constructor(private listingService: ListingService)
  {
    
  }

  ngOnInit() {
    this.listingService.getListings().subscribe(response => {
      this.listings = response;
      this.listingPages = new Array(this.calculatePageCount(this.getListingCount(), this.listingsPerPage));
    });
  }

  calculatePageCount(totalItems : number, itemsPerPage : number) : number {
    return Math.ceil(totalItems / itemsPerPage);
  }

  getListingCount() {
    return this.listings.length;
  }

  getPageCount() {
    return this.listingPages.length;
  }
}
