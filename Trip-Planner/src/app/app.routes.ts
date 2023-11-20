import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { PopularTripsComponent } from './popular-trips/popular-trips.component';
import { PopularCountryComponent } from './popular-country/popular-country.component';
import { TripComponent } from './trip/trip.component';
import { ActiviteitComponent } from './activiteit/activiteit.component';

import { CategoryListComponent } from './land-list/land-list.component';


export const routes: Routes = [
    {path:"", component: HomeComponent},
    {path:"popular-trips", component: PopularTripsComponent},
    {path:"popular-country", component: PopularCountryComponent},
    {path:"trip", component: TripComponent},
    {path: "activiteit", component: ActiviteitComponent},
    {path: "land", component: CategoryListComponent},

  ];