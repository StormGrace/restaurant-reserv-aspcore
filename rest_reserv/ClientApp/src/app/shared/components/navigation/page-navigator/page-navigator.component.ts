import { Component, OnInit, Input, ElementRef } from '@angular/core';
import { max } from 'rxjs/operators';

@Component({
  selector: 'PageNavigator',
  templateUrl: './page-navigator.component.html',
  styleUrls: ['./page-navigator.component.scss'],
  host: { 'class': 'page-nav-wrapper' }
})
export class PageNavigatorComponent implements OnInit {

  private _pages: number[];

  private _currentPage: number;

  private _pagesVisible: number;

  private _callback: Function;

  private _ref: any;

  private _startingPage: number;

  constructor(private elemRef : ElementRef) { }

  ngOnInit() {
    this._currentPage = 1;
  }

  ngAfterViewInit() {
    this.updatePageNumber(0);
  }

  ngOnDestroy() {
    
  }

  @Input() set callback(value: Function) {
    this._callback = value;
  }

  @Input() set ref(value: Function) {
    this._ref = value;
  }

  get callback(): Function {
    return this._callback;
  }

  @Input() set pages(value: number) {
    this._pages = new Array(value);
  }

  get pages(): number {
    return this._pages.length;
  }

  @Input() set pagesVisible(value: number) {
    this._pagesVisible = value;
  }

  get pagesVisible(): number {
    return this._pagesVisible;
  }

  updatePageNumber(newPage: number) {

    newPage = Math.max(0, Math.min(newPage, this.pages - 1));

    if (this._currentPage != newPage) {
      let oldPageItem = document.getElementsByClassName("page-num-btn--selected")[0];

      if (oldPageItem != null)
        oldPageItem.classList.remove("page-num-btn--selected");

      var pageItem = document.getElementsByClassName("page-num-btn").item(newPage);

      pageItem.classList.add("page-num-btn--selected");

      this._currentPage = newPage;

      this.callback(this._currentPage, this._ref);

      console.log(this._currentPage);
    }
  }

  onPageClick(event) {
    let target = event.target;

    let newPage = Array.from(target.parentNode.children).indexOf(target);

    this.updatePageNumber(newPage - 1)
  }

  onNavClick(event) {
    let target = event.target;

    let newPage: number;

    if (target.classList.contains('page-nav-button--prev'))
    {
      newPage = this._currentPage - 1;
    }
    else
    {
      newPage = this._currentPage + 1;
    }

    this.updatePageNumber(newPage);
  }
}
