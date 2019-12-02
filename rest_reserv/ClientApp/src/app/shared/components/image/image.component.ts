import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'Image',
  templateUrl: './image.component.html',
  styleUrls: ['./image.component.scss'],
  host: {'class':'image'}
})
export class ImageComponent implements OnInit {

  private _imagePath: string;

  private _width: string = "100";
  private _height: string = "100";

  private hasLoaded: boolean;

  constructor() { this.hasLoaded = false;}

  ngOnInit() {
    this.hasLoaded = false;
  }

  ngOnDestroy() {
    this.hasLoaded = false;
  }

  @Input() set imagePath(value: string) {
    this._imagePath = value;
  }

  get imagePath(): string {
    return this._imagePath
  }

  @Input() set width(value: string) {
    this._width = value;
  }

  get width(): string {
    return this._width;
  }

  @Input() set height(value: string) {
    this._height = value;
  }

  get height(): string {
    return this._height;
  }

  onLoad() {
    if(this.hasLoaded == false)
      this.hasLoaded = true;
  }
}
