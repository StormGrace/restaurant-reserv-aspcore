import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'ListingReviews',
  templateUrl: './listing-reviews.component.html',
  styleUrls: ['./listing-reviews.component.scss'],
})
export class ListingReviewsComponent implements OnInit {

  private reviewsPerPage: number = 10;

  constructor() { }

  ngOnInit() {
  }

}
