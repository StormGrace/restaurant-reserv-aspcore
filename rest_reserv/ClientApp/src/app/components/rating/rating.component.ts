import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'Rating',
  templateUrl: './rating.component.html',
  styleUrls: ['./rating.component.scss'],
  host: {'class':'rating'}
})
export class RatingComponent implements OnInit {

  totalStars: number = 5;

  stars: number[];

  constructor() { this.stars = new Array(this.totalStars);}

  ngOnInit() {
  }

  selectStars(stars: number) {
    
  }

  onStarSelect(event) {
    let target = event.target;

    let stars: Element[];

    stars = Array.from(target.parentNode.children);

    stars.reverse();

    let index = stars.indexOf(target) + 1;

    let selectedStars: Element[];

    selectedStars = stars.slice(0, index);

    for (let i = 0; i < selectedStars.length; i++) {
      selectedStars[i].classList.add('class', 'star--selected');
    }
  }
}
