import { Activiteit } from "./Activiteit";
import { Plaats } from "./Plaats";
import { Trip } from "./Trip";

export class Verblijf extends Activiteit{
    adres: string;
    slaapPlaatsen: number;
    prijsPerNacht: number;
    
    constructor(activiteitId: number, activiteitNaam: string, plaats: Plaats, startDatum: Date, eindDatum: Date, personenAantal: number, adres: string, slaapPlaatsen: number, prijsPerNacht: number, trip: Trip) {
        super(activiteitId, activiteitNaam, plaats, startDatum, eindDatum, personenAantal, trip);
        this.adres = adres;
        this.slaapPlaatsen = slaapPlaatsen;
        this.prijsPerNacht = prijsPerNacht;
    }
}