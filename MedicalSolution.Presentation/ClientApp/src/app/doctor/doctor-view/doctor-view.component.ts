import { Component, OnInit } from '@angular/core';
import { DoctorViewService } from './doctor-view.service';

@Component({
  selector: 'app-doctor-view',
  templateUrl: './doctor-view.component.html',
  styleUrls: ['./doctor-view.component.css'],
  providers: [DoctorViewService]
})
export class DoctorViewComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
