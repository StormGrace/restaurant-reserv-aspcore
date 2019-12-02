import { NgModule } from "@angular/core";

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';

import { RouterModule } from '@angular/router';

import { ListingInfoComponent } from "../../../components/listing-info/listing-info.component";
import { ListingReviewComponent } from '../../../components/listing-reviews/listing-review/listing-review.component';
import { ListingReviewsComponent } from '../../../components/listing-reviews/listing-reviews.component';

import { ListingGalleryComponent } from "../../../components/listing-gallery/listing-gallery.component";
import { ListingGalleryFilterComponent } from "../../../components/listing-gallery-filter/listing-gallery-filter.component";
import { ListingItemComponent } from "../../../components/listing-gallery/listing-item/listing-item.component";
import { PageNavigatorComponent } from "../../../shared/components/navigation/page-navigator/page-navigator.component";

import { ImageComponent } from '../../../shared/components/image/image.component';
import { ButtonComponent } from "../../../shared/components/button/button.component";
import { IconButtonComponent } from "../../../shared/components/button/icon-button/icon-button.component";
import { RatingComponent } from "../../../components/rating/rating.component";

import { ListingService } from '../../../services/listing.service';

 

@NgModule({
  declarations: [
    ListingInfoComponent,
    ListingGalleryFilterComponent,
    ListingGalleryComponent,
    ListingItemComponent,
    PageNavigatorComponent,
    ButtonComponent,
    ImageComponent,
    RatingComponent,
    IconButtonComponent,
    ListingReviewComponent,
    ListingReviewsComponent,
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    RouterModule
  ],
  providers: [
    ListingService,
  ],
  exports: [
    ListingGalleryFilterComponent,
    ListingGalleryComponent,
    ListingInfoComponent,
    ListingReviewsComponent
  ],
})
export class ListingModule {}
