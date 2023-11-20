import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Trip } from '../classes/Trip';
import { TripService } from '../trip.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-trip-form',
  templateUrl: './trip-form.component.html',
  styleUrls: ['./trip-form.component.css']
})
export class TripFromComponent implements OnInit, OnDestroy {
  isAdd: boolean = false;
  isEdit: boolean = false;
  tripId: number = 0;

  trip: Trip = {
    tripId: 0, naam: "",
    startDatum: undefined,
    eindDatum: null,
    lengte: 0,
    userTrip: null,
    activiteiten: [],
    userTrips: []
  };

  isSubmitted: boolean = false;
  errorMessage: string = "";

  trip$: Subscription = new Subscription();
  postTrip$: Subscription = new Subscription();
  putTrip$: Subscription = new Subscription();

  constructor(private router: Router, private tripService: TripService) {
    this.isAdd = this.router.getCurrentNavigation()?.extras.state?.['mode'] === 'add';
    this.isEdit = this.router.getCurrentNavigation()?.extras.state?.['mode'] === 'edit';
    this.tripId = +this.router.getCurrentNavigation()?.extras.state?.['id'];

    if (!this.isAdd && !this.isEdit) {
      this.isAdd = true;
    }

    if (this.tripId != null && this.tripId > 0) {
      this.trip$ = this.tripService.getTripsById(this.tripId).subscribe(result => this.trip = result);
    }

  }

  ngOnInit(): void {
  }

  ngOnDestroy(): void {
    this.trip$.unsubscribe();
    this.postTrip$.unsubscribe();
    this.putTrip$.unsubscribe();
  }

  onSubmit() {
    this.isSubmitted = true;
    if (this.isAdd) {
      this.postTrip$ = this.tripService.postTrips(this.trip).subscribe({
        next: (v) => this.router.navigateByUrl("/admin/category"),
        error: (e) => this.errorMessage = e.message
      });
    }
    if (this.isEdit) {
      this.putTrip$ = this.tripService.putTrips(this.tripId, this.trip).subscribe({
        next: (v) => this.router.navigateByUrl("/admin/category"),
        error: (e) => this.errorMessage = e.message
      });
    }
  }
}
