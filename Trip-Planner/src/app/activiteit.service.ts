// activity.service.ts
import { Injectable } from '@angular/core';
import { Activiteit } from './classes/Activiteit';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root',
})
export class ActivityService {
  private apiUrl = 'https://localhost:7155/api/get/activiteiten'; // Vervang dit door de daadwerkelijke API-URL

  constructor(private http: HttpClient) {}


  getActivities(): Observable<Activiteit[]> {
    return this.http.get<Activiteit[]>(this.apiUrl);
  }

  getActivityById(id: number): Observable<Activiteit> {
    return this.http.get<Activiteit>(`${this.apiUrl}/${id}`);
  }

  addActivity(activity: Activiteit): Observable<Activiteit> {
    return this.http.post<Activiteit>(this.apiUrl, activity);
  }

  updateActivity(activity: Activiteit): Observable<Activiteit> {
    return this.http.put<Activiteit>(`${this.apiUrl}/${activity.activiteitId}`, activity);
  }

  deleteActivity(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
