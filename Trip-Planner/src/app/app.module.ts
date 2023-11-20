import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'; // Zorg ervoor dat je dit hebt toegevoegd
import { MenuComponent } from './menu/menu.component';

@NgModule({
  declarations: [
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    FormsModule,
    MenuComponent,
  ],
  providers: [],
})
export class AppModule { }