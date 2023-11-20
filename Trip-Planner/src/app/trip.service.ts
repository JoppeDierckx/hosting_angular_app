import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Trip } from './classes/Trip';

@Injectable({
    providedIn: 'root'
})
export class TripService {

    constructor(private httpClient: HttpClient) { }

    getTrips(): Observable<Trip[]> {
        return this.httpClient.get<Trip[]>("https://localhost:7155/api");
    }

    getTripsById(id: number): Observable<Trip> {
        return this.httpClient.get<Trip>("https://localhost:7155/api" + id);
    }

    postTrips(category: Trip): Observable<Trip> {
        let headers = new HttpHeaders();
        headers = headers.set('Content-Type', 'application/json; charset=utf-8');

        return this.httpClient.post<Trip>("https://localhost:7155/api", category, {headers: headers});
    }

    putTrips(id:number, category: Trip): Observable<Trip> {
        let headers = new HttpHeaders();
        headers = headers.set('Content-Type', 'application/json; charset=utf-8');

        return this.httpClient.put<Trip>("https://localhost:7155/api" + id, category, {headers: headers});
    }

    deleteTrips(id: number): Observable<Trip> {
        return this.httpClient.delete<Trip>("https://localhost:7155/api" + id);
    }
}