import { Activiteit } from "./Activiteit";
import { Plaats } from "./Plaats";
import { Trip } from "./Trip";

export class Verplaatsing extends Activiteit{
    eindplaats: Plaats;
    prijs: number;
    
    constructor(activiteitId: number, activiteitNaam: string, plaats: Plaats, startDatum: Date, eindDatum: Date, personenAantal: number, eindplaats: Plaats, prijs: number, trip: Trip) {
        super(activiteitId, activiteitNaam, plaats, startDatum, eindDatum, personenAantal, trip);
        this.eindplaats = eindplaats;
        this.prijs = prijs;
    }
}