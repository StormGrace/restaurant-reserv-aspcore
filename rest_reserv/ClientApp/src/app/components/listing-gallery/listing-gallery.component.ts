import { Component, OnInit } from '@angular/core';

import { ListingService, Listing } from '../../services/listing.service';

import { BehaviorSubject } from 'rxjs';
import { Reference } from '@angular/compiler/src/render3/r3_ast';
import { Router } from '@angular/router';

@Component({
  selector: "ListingGallery",
  templateUrl: "./listing-gallery.component.html",
  styleUrls: ["./listing-gallery.component.scss"],
  host: { 'class': 'listings-wrapper' }
})
export class ListingGalleryComponent implements OnInit {

  private listings: Listing[];

  public filteredListings: Listing[];

  public currentStartIndex: number;

  public currentEndIndex: number;

  public listingsPerPage: number = 12; //Even Number.

  public isPageChanged: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);

  public pageCount: number;

  public self : any = this;

  constructor(private listingService: ListingService, private router: Router)
  {
    
  }

  ngOnInit() {
    this.listingService.getListings().subscribe(response => {
      this.listings = response;
      this.pageCount = (this.calculatePageCount(this.getListingCount(), this.listingsPerPage));
      this.filterListings(0);
    });
  }

  calculatePageCount(totalItems : number, itemsPerPage : number) : number {
    return Math.ceil(totalItems / itemsPerPage);
  }

  getListingCount() {
    return this.listings.length;
  }

  filterListings(pageNumber: number = 0) {
    let startIndex = this.listingsPerPage * pageNumber;
    let endIndex = startIndex + this.listingsPerPage;

    this.currentStartIndex = startIndex + 1;
    this.currentEndIndex = Math.min(endIndex, this.getListingCount());

    this.filteredListings = this.listings.slice(startIndex, endIndex);
  }

  updateListings(pageNumber: number, ref: any) {
    console.log("Updating Gallery!");

    ref.filterListings(pageNumber);
  }

  getListingInfo(listingName: string) {
    if (listingName != null) {
      let listingURL: string = "listing/" + listingName.toLowerCase().replace(/\s+/g, '-');

      this.router.navigateByUrl(listingURL, {
        state: { example: 'data' }
      });
    }
  }
}
