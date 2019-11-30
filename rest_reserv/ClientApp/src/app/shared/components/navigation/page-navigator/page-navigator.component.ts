import { Component, OnInit, Input, ElementRef } from '@angular/core';

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

  constructor(private elemRef : ElementRef) { }

  ngOnInit() {
    this._currentPage = 1;
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


  onPageClick(event) {
    let target = event.target;

    let oldTarget = document.getElementsByClassName("page-num-btn--selected")[0];

    if (oldTarget != null) {
      oldTarget.classList.remove("page-num-btn--selected");
    }

    target.classList.add("page-num-btn--selected");

    let pageSelected = Array.from(target.parentNode.children).indexOf(target);

    this._currentPage = pageSelected + 1;

    this.callback(pageSelected, this._ref);
  }
}
