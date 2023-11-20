import { Plaats } from "./Plaats";
import { Trip } from "./Trip";

export class Activiteit {
    activiteitId: number;
    activiteitNaam:string;
    plaats: Plaats;
    startDatum: Date;
    eindDatum: Date;
    personenAantal: number;
    trip: Trip;
    
    constructor(activiteitId: number, activiteitNaam:string, plaats: Plaats, startDatum: Date, eindDatum: Date, personenAantal: number, trip: Trip) {
        this.activiteitId = activiteitId;
        this.activiteitNaam =activiteitNaam;
        this.plaats = plaats;
        this.startDatum = startDatum;
        this.eindDatum = eindDatum;
        this.personenAantal = personenAantal;
        this.trip = trip;
    }

}