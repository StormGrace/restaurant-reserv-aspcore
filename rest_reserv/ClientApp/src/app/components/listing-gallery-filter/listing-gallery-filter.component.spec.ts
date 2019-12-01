import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListingGalleryFilterComponent } from './listing-gallery-filter.component';

describe('ListingGalleryFilterComponent', () => {
  let component: ListingGalleryFilterComponent;
  let fixture: ComponentFixture<ListingGalleryFilterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListingGalleryFilterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListingGalleryFilterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
