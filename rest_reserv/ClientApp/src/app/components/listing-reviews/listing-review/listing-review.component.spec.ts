import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListingReviewComponent } from './listing-review.component';

describe('ListingReviewComponent', () => {
  let component: ListingReviewComponent;
  let fixture: ComponentFixture<ListingReviewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListingReviewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListingReviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
