import { Injectable } from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http';
import { Fruits } from '../Models/fruits';
import {map, catchError} from 'rxjs/operators'
import { throwError } from 'rxjs/internal/observable/throwError';

@Injectable({
  providedIn: 'root'
})
export class AddFruitService {
  fruit:Fruits = new Fruits();
  constructor(private http : HttpClient) {
    console.log("Hello from service");
   }

   SaveFruit(fruitJson :string)   {
    let headers = new HttpHeaders();
    headers = headers.set('Content-Type', 'text/json');

     return this.http.post<Fruits>("http://localhost:5000/api/values",fruitJson,{headers})
     .pipe(map((response : Fruits) => {
     return response;
    }
     ),
     catchError(this.handleErrors)
     )
     ;
   }

   private handleErrors(error : HttpErrorResponse)
   {
return throwError('AN error Occurred!');
   }

   DeleteFruit(fruitJson :string)   {
    let headers = new HttpHeaders();
    headers = headers.set('Content-Type', 'text/json');

     return this.http.post<Fruits>("http://localhost:5000/api/values",fruitJson,{headers})
     .pipe(map((response : Fruits) => {
     return response;
    }
     ),
     catchError(this.handleErrors)
     )
     ;
   }
}
