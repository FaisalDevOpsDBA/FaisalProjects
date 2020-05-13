import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { NgForm, FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { FruitListComponent } from './fruit-list/fruit-list.component';
import { FruitListService } from './services/fruit-list.service';
import { AddFruitComponent } from './add-fruit/add-fruit.component';
import { PageNotFoundComponent } from './others/page-not-found/page-not-found.component'

@NgModule({
  declarations: [
    AppComponent,    
    FruitListComponent, AddFruitComponent, PageNotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [FruitListService],
  bootstrap: [AppComponent]
})
export class AppModule { }
