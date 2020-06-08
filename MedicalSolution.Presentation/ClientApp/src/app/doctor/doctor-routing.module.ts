import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { DoctorListComponent } from './doctor-list/doctor-list.component';

const doctorRoutes : Routes = [
  {
    path: 'doctor',
    children: [
      {
        path: '',
        component: DoctorListComponent
      }
    ]
  }
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(doctorRoutes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class DoctorRoutingModule { }
