import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Land } from './classes/Land';

@Injectable({
  providedIn: 'root'
})
export class LandService {

  constructor(private httpClient: HttpClient) { }

  apiUrl: string= "https://localhost:7155/api/get/activiteiten"; 

  getCategories(): Observable<Land[]> {
    return this.httpClient.get<Land[]>("http://localhost:3000/landen");
  }

  getCategoryById(id: number): Observable<Land> {
      return this.httpClient.get<Land>("http://localhost:3000/landen/" + id);
  } 

  postCategory(category: Land): Observable<Land> {
      let headers = new HttpHeaders();
      headers = headers.set('Content-Type', 'application/json; charset=utf-8');

      return this.httpClient.post<Land>("http://localhost:3000/landen", category, {headers: headers});
  }

  putCategory(id:number, category: Land): Observable<Land> {
      let headers = new HttpHeaders();
      headers = headers.set('Content-Type', 'application/json; charset=utf-8');

      return this.httpClient.put<Land>("http://localhost:3000/landen/" + id, category, {headers: headers});
  }

  deleteCategory(id: number): Observable<Land> {
      return this.httpClient.delete<Land>("http://localhost:3000/landen/" + id);
  }
}