import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PacienteListComponent } from './paciente-list/paciente-list.component';
import { PacienteAddComponent } from './paciente-add/paciente-add.component';
import { PacienteUpdateComponent } from './paciente-update/paciente-update.component';
import { PacienteRoutingModule } from './paciente-routing.module';
import { PacienteViewComponent } from './paciente-view/paciente-view.component';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
  imports: [
    CommonModule,
    PacienteRoutingModule,
  ],
  entryComponents: [
    PacienteListComponent,
    PacienteAddComponent
  ],
  declarations: [PacienteListComponent, PacienteAddComponent, PacienteUpdateComponent, PacienteViewComponent]
})
export class PacienteModule { }
