import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Medicines } from './medicines'
@Injectable({
  providedIn: 'root'
})
export class MedicinesService {
  _baseURL:string="/api/MTS";
  constructor(private http:HttpClient) { }

  getAllMedicines()
  {
    return this.http.get<Medicines[]>(this._baseURL+"/GetMedicines");
  }
  getMedicineById(id:string){
    return this.http.get<Medicines>(this._baseURL+"/SingleMedicine/"+id);
  }
}
