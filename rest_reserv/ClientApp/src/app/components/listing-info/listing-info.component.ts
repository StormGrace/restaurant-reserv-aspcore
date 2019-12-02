import { Component, OnInit } from '@angular/core';

import { ListingService, ListingInfo } from '../../services/listing.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'ListingInfo',
  templateUrl: './listing-info.component.html',
  styleUrls: ['./listing-info.component.scss'],
  host: {'class':'listing__info'}
})
export class ListingInfoComponent implements OnInit {

  private listing: ListingInfo;

  private _listingName: string;

  constructor(private listingService: ListingService, private route: ActivatedRoute, private router : Router) {

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
        if (response == null) {
          this.router.navigate(['**']);
        } else {
          this.listing = response;
        }
      });
    }
  }

}
