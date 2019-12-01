import { Component, Directive, OnInit } from '@angular/core';


@Component({
  selector: 'CButton',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.scss'],
  host: {'class' : 'button'}
})
export class ButtonComponent implements OnInit {

  constructor() { }

  ngOnInit()
  {

  }

  ngAfterViewInit()
  {

  }
}
