import { Activiteit } from "./Activiteit";
import { UserTrip } from "./UserTrip";

export class Trip {
    tripId: number;
    startDatum?: Date | undefined;
    eindDatum: Date | null;
    lengte: number;
    naam: string;
    userTrip: UserTrip | null;
    activiteiten: Activiteit[] = [];
    userTrips: UserTrip[] = [];
    
    constructor(tripId: number, startDatum: Date, eindDatum: Date, lengte: number, userTrip: UserTrip, naam:string){
        this.tripId = tripId;
        this.startDatum = startDatum;
        this.eindDatum = eindDatum;
        this.naam = naam;
        this.lengte = lengte;
        this.userTrip = userTrip;
    }
}