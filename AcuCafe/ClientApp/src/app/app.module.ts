import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from "./app.component.js";
import { DrinksComponent }  from "./drinks/drinks.component.js";

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent, DrinksComponent ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
