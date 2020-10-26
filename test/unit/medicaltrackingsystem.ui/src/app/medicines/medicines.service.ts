import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { retry } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Medicines } from '../../api/mts/mts.json';

@Injectable()
export class MedicinesService {
  constructor(private http: HttpClient) {}

  getFavoriteMovies(): Observable<any> {
    return this.http.get<any>(environment.favoriteUrl).pipe(retry(2));
  }
}
