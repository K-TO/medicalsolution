import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DoctorListComponent } from './doctor-list/doctor-list.component';
import { DoctorRoutingModule } from './doctor-routing.module';
import { DoctorViewComponent } from './doctor-view/doctor-view.component';

@NgModule({
  imports: [
    CommonModule,
    DoctorRoutingModule
  ],
  declarations: [DoctorListComponent, DoctorViewComponent]
})
export class DoctorModule { }
