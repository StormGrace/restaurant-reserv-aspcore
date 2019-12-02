import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'IconButton',
  templateUrl: './icon-button.component.html',
  styleUrls: ['./icon-button.component.scss'],
  host: {'class': 'icon-btn'}
})
export class IconButtonComponent implements OnInit {

  private _iconClass: string;

  constructor() { }

  ngOnInit() {
  }

  @Input() set iconClass(value: string) {
    this._iconClass = value;
  }

  get iconClass(): string {
    return this._iconClass;
  }
}
