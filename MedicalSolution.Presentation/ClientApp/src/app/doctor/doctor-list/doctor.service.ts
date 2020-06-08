import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Doctor } from '../models/doctor';

@Injectable({
  providedIn: 'root'
})
export class DoctorService {
  baseUrl = './'
  constructor(private http:HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this.baseUrl = baseUrl;
  }

  getDoctorList(): Observable<Doctor[]>{
    return this.http.get<Doctor[]>(this.baseUrl + 'api/doctor/');
  }
}
