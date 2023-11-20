import { Plaats } from "./Plaats";
import { UserTrip } from "./UserTrip";

export class Gebruiker {
    userId: number;
    voornaam: string;
    achternaam: string;
    mail: string;
    wachtwoord: string;
    isAdmin: boolean;
    isActief: boolean;
    adres: String;
    plaats: Plaats;
    userTrips: UserTrip[] = [];


    constructor(userId: number, voornaam: string, achternaam: string, mail: string, wachtwoord: string, isAdmin: boolean, isActief: boolean, adres: String, plaats: Plaats) {
        this.userId = userId;
        this.voornaam = voornaam;
        this.achternaam = achternaam;
        this.mail = mail;
        this.wachtwoord = wachtwoord;
        this.isAdmin = isAdmin;
        this.isActief = isActief;
        this.adres = adres;
        this.plaats = plaats;
    }

}
