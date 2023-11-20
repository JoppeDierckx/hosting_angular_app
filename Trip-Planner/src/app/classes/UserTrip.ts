import { Gebruiker } from "./Gebruiker";
import { Trip } from "./Trip";

export class UserTrip {
    trip: Trip;
    gebruiker: Gebruiker;
    isEigenaar: boolean;
    
    constructor(trip: Trip, gebruiker: Gebruiker, isEigenaar: boolean,) {
        this.trip = trip;
        this.gebruiker = gebruiker;
        this.isEigenaar = isEigenaar;
    }
}