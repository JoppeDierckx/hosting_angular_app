import { Activiteit } from "./Activiteit";
import { Gebruiker } from "./Gebruiker";
import { Land } from "./Land";

export class Plaats {
    plaatsId: number;
    land: Land;
    naam:string;
    postcode: string;
    gebruikers: Gebruiker[] = [];
    activiteiten: Activiteit[] = [];

    constructor(plaatsId: number, land: Land, naam:string, postcode: string,) {
        this.plaatsId = plaatsId;
        this.land = land;
        this.naam = naam;
        this.postcode = postcode;
    }
}