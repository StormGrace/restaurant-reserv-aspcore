import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
    constructor() {
        document.body.style.background = 'rgba(1,1,1,1)';
    }
  title = '';
}
