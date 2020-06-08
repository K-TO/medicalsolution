import { Component, OnInit } from '@angular/core';
import { Paciente } from '../models/paciente';
import { PacienteService } from './paciente.service';

@Component({
  selector: 'app-paciente-list',
  templateUrl: './paciente-list.component.html',
  styleUrls: ['./paciente-list.component.css']
})
export class PacienteListComponent implements OnInit {

  pacientes: Paciente[] = [];
  paciente: Paciente;

  constructor(private pacienteService: PacienteService) { 
    this.getPatients();
  }

  ngOnInit() {
  }

  getPatients(): void {
    this.pacienteService.getPatientList()
                        .subscribe(
                          response => this.pacientes = response
                        );
  }

  newPatient(): void {
     
  }

}
