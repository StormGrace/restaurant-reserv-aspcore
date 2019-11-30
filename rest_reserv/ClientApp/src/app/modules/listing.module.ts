import { NgModule } from "@angular/core";

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';

import { ListingGalleryComponent } from "../components/listing-gallery/listing-gallery.component";
import { ListingItemComponent } from "../components/listing-gallery/listing-item/listing-item.component";
import { PageNavigatorComponent } from "../shared/components/navigation/page-navigator/page-navigator.component";

import { ListingService } from './../services/listing.service';

@NgModule({
  declarations: [
    ListingGalleryComponent,
    ListingItemComponent,
    PageNavigatorComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
  ],
  providers: [
    ListingService,
  ],
  exports: [ListingGalleryComponent],
})
export class ListingModule {}
