import { NgModule } from "@angular/core";

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';

import { RouterModule } from '@angular/router';

import { ListingGalleryComponent } from "../../../components/listing-gallery/listing-gallery.component";
import { ListingGalleryFilterComponent } from "../../../components/listing-gallery-filter/listing-gallery-filter.component";
import { ListingItemComponent } from "../../../components/listing-gallery/listing-item/listing-item.component";
import { PageNavigatorComponent } from "../../../shared/components/navigation/page-navigator/page-navigator.component";
import { ButtonComponent } from "../../../shared/components/button/button.component";
import { RatingComponent } from "../../../components/rating/rating.component";

import { ListingService } from '../../../services/listing.service';

@NgModule({
  declarations: [
    ListingGalleryFilterComponent,
    ListingGalleryComponent,
    ListingItemComponent,
    PageNavigatorComponent,
    ButtonComponent,
    RatingComponent,
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    RouterModule
  ],
  providers: [
    ListingService,
  ],
  exports: [ListingGalleryComponent],
})
export class ListingModule {}
