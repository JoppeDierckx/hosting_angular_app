import { Activiteit } from "./Activiteit";
import { Plaats } from "./Plaats";
import { Trip } from "./Trip";

export class Entertainment extends Activiteit{
    prijsPerPersoon: number;
    
    constructor(activiteitId: number, activiteitNaam: string, plaats: Plaats, startDatum: Date, eindDatum: Date, personenAantal: number, prijsPerPersoon: number, trip: Trip) {
        super(activiteitId, activiteitNaam, plaats, startDatum, eindDatum, personenAantal, trip);
        this.prijsPerPersoon = prijsPerPersoon;
        
    }
}