import { Component, OnInit } from '@angular/core';

import { ListingService, Listing } from '../../../../services/listing.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'Listing',
  templateUrl: './listing.component.html',
  styleUrls: ['./listing.component.css']
})
export class ListingComponent implements OnInit {

  private listing: Listing;
  private _listingName: string;

  constructor(private listingService: ListingService, private route: ActivatedRoute)
  {
 
  }

  ngOnInit() {
    //this.route.paramMap.pipe(map(paramMap => paramMap.get("name"))));
    //this._listingName = this.router.getCurrentNavigation().extras['state'];

    this._listingName = this.route.snapshot.paramMap.get("name");

    this.fetchDataByName(this._listingName);
  }

  set listingName(value: string) {
    this.listingName = value;
  }

  get listingName(): string {
    return this._listingName;
  }

  fetchDataByName(listingName: string) {
    if (listingName != null) {
        this.listingService.getListing(listingName).subscribe(response => {
          this.listing = response;
          console.log(response);
      });
    }
  }
}
