import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { PacienteListComponent } from './paciente-list/paciente-list.component';
import { PacienteAddComponent } from './paciente-add/paciente-add.component';
import { PacienteUpdateComponent } from './paciente-update/paciente-update.component';

const pacienteRoutes :  Routes = [
  {
    path: 'paciente',
    children: [
      {
        path: '',
        component: PacienteListComponent
      },
      {
        path: 'add',
        component: PacienteAddComponent
      },
      {
        path: 'update',
        component: PacienteUpdateComponent
      }
    ]
  }
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(pacienteRoutes)
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class PacienteRoutingModule { }
