import { Component, OnInit } from '@angular/core';
import { FruitListService } from '../Services/fruit-list.service';
import { Fruits } from '../Models/fruits';
import { Observable, Observer,Subscriber,Subscription } from 'rxjs'
@Component({
  selector: 'app-fruit-list',
  templateUrl: './fruit-list.component.html',
  styleUrls: ['./fruit-list.component.css']
})
export class FruitListComponent implements OnInit {

  fruitList : Fruits[] = [];

  constructor(private fruitListService : FruitListService) { }

  ngOnInit() {
    //this.fruitList = this.fruitListService.GetFruitList()
    this.fruitListService.GetFruitListFromApi()
    .subscribe((data : Fruits[]) => this.fruitList = data)

    // this.fruitListService.GetFruitListFromApiPromise()
    // .then((data) => this.fruitList = data)
    // ;
  }

  DeleteFruit(fruitId)
  {
    this.fruitListService.DeleteFruit(fruitId);
  }

}
