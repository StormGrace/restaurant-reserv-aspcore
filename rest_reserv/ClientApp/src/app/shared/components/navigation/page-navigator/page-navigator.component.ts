import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-page-navigator',
  templateUrl: './page-navigator.component.html',
  styleUrls: ['./page-navigator.component.css']
})
export class PageNavigatorComponent implements OnInit {

  private _pages: number[];

  private pageCount: number;
  private visiblePages: number;

  constructor() { }

  ngOnInit() {

  }

  set pages(pages: number[]) {
    this.pages = pages;
  }
}
