import { Component, Input, OnInit } from '@angular/core';
import { faMale, faFemale } from '@fortawesome/free-solid-svg-icons';

import { NameService } from './name-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Names list!';
  faMale = faMale;
  faFemale = faFemale;

  public namesData: Array<string>;

  constructor(private nameService: NameService) {
    nameService.get().subscribe((data: any) => this.namesData = data);
  }
}
