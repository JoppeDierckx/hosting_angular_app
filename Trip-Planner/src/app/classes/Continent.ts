import { Land } from "./Land";

export class Continent {
    continentId: number;
    naam:string;
    landen: Land[] = [];
    
    constructor(continentId: number, naam:string) {
        this.continentId = continentId;
        this.naam = naam;
    }
}