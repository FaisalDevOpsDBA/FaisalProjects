import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {map} from 'rxjs/operators';  
import { Fruits } from '../Models/fruits';
import { listLazyRoutes } from '@angular/compiler/src/aot/lazy_routes';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators'; 

@Injectable({
  providedIn: 'root'
})
export class FruitListService {
  fruitList:[Fruits];
  constructor(private http : HttpClient) {
    console.log("Hello from service");
   }

   GetFruitList(){
     let f = new Fruits();
     f.color = "Red";
     f.fruit = "Apple";
     f.id = 1;
     f.size = "Large";

     let list : Fruits[] = [];
     list.push(f);
     f = new Fruits();
     f.color = "Green";
     f.fruit = "Grapes";
     f.id = 22;
     f.size = "Large";
     list.push(f);
     return list;
     //return this.http.get()
   }

   GetFruitListFromApi()
   {
     return this.http.get<Fruits[]>("http://localhost:5000/api/values");
   }

   GetFruitListFromApiPromise()
   {
     return this.http.get<Fruits[]>("http://localhost:5000/api/values").toPromise();
   }
}
