import { Continent } from "./Continent";
import { Plaats } from "./Plaats";

export class Land {
    landId: number;
    naam:string;
    continent: Continent;
    plaatsen: Plaats[] = [];
    
    constructor(landId: number, naam:string, continent: Continent,) {
        this.landId = landId;
        this.naam = naam;
        this.continent = continent;
    }
}