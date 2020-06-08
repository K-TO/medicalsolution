import { Component, OnInit } from '@angular/core';
import { DoctorService } from './doctor.service';
import { Doctor } from '../models/doctor';
import { ConfirmationDialogService } from 'src/app/shared/confirmation-dialog/confirmation-dialog.service';

@Component({
  selector: 'app-doctor-list',
  templateUrl: './doctor-list.component.html',
  styleUrls: ['./doctor-list.component.css'],
  providers: [DoctorService]
})
export class DoctorListComponent implements OnInit {

  doctores: Doctor[] = [];
  doctor: Doctor;

  constructor(private doctorService: DoctorService, private confirmationDialogService: ConfirmationDialogService) { 
    this.getDoctors();
  }

  ngOnInit() {

  }

  getDoctors(): void {
    this.doctorService.getDoctorList()
                      .subscribe(
                        response => this.doctores = response
                      );
  }

  viewDoctor(doctorId): void {
    console.log('Doctor id is => ' + doctorId)
    
  }

}
