import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Trip } from '../classes/Trip';
import { TripService } from '../trip.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-trip',
  templateUrl: './trip.component.html',
  styleUrls: ['./trip.component.css']
})
export class TripComponent implements OnInit, OnDestroy {
  trips: Trip[] = [];
  trips$: Subscription = new Subscription();
  deletetrips$: Subscription = new Subscription();

  errorMessage: string = '';

  constructor(private Tripservice: TripService, private router: Router) {
  }

  ngOnInit(): void {
    this.getTrips();
  }

  ngOnDestroy(): void {
    this.trips$.unsubscribe();
    this.deletetrips$.unsubscribe();
  }

  add() {
    //Navigate to form in add mode
    this.router.navigate(['admin/trip/form'], { state: { mode: 'add' } });
  }

  edit(id: number) {
    //Navigate to form in edit mode
    this.router.navigate(['admin/trip/form'], { state: { id: id, mode: 'edit' } });
  }

  delete(id: number) {
    this.deletetrips$ = this.Tripservice.deleteTrips(id).subscribe({
      next: (v) => this.getTrips(),
      error: (e) => this.errorMessage = e.message
    });
  }

  getTrips() {
    this.trips$ = this.Tripservice.getTrips().subscribe(result => this.trips = result);
  }

}
