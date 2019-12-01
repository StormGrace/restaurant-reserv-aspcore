import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest } from "@angular/common/http";
import { Observable } from 'rxjs';


export interface Listing {
  listingTitle: string,
  listingDescription: string,
  listingImgPath: string,
  listingReviewCount: number,
}

@Injectable({
  providedIn: 'root'
})
export class ListingService {
  private readonly getURL = 'http://localhost:50905/Listing/';

  constructor(private http: HttpClient)
  {
  }

  public getListings(): Observable<Listing[]>
  {
    return this.http.get<Listing[]>(this.getURL + 'GetListings');
  }

  public getListing(name: string): Observable<Listing>
  {
    return this.http.get<Listing>(this.getURL + 'GetListing?name=' + name);
  }
}

