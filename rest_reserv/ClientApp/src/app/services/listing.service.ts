import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest } from "@angular/common/http";
import { Observable } from 'rxjs';


export interface Listing {
  listingTitle: string,
  listingImgPath: string,
  listingReviewCount: number,
}

export interface ListingInfo {
  listingTitle: string,
  listingPhone: string,
  listingWebsite: string,
  listingDescription: string,
  listingReviewCount: number,
  listingnImgPath: string,
  listingRating: number,
}

@Injectable({
  providedIn: 'root'
})
export class ListingService {
  private readonly getURL = 'http://localhost:50260/Listing/';

  constructor(private http: HttpClient)
  {
  }

  public getListings(): Observable<Listing[]>
  {
    return this.http.get<Listing[]>(this.getURL + 'GetListings');
  }

  public getListing(name: string): Observable<ListingInfo>
  {
    return this.http.get<ListingInfo>(this.getURL + 'GetListing?name=' + name);
  }
}

