import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Paciente } from '../models/paciente';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PacienteService {
  baseUrl = './'
  constructor(private http:HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this.baseUrl = baseUrl;
  }

  getPatientList(): Observable<Paciente[]>{
    return this.http.get<Paciente[]>(this.baseUrl + 'api/paciente/');
  }
}
