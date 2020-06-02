import { Component, OnInit, NgZone, ChangeDetectorRef, ChangeDetectionStrategy } from '@angular/core';
import { Fruits } from '../Models/fruits';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';


import { AddFruitService } from '../Services/add-fruit.service';

@Component({
  selector: 'app-add-fruit',
  templateUrl: './add-fruit.component.html',
  styleUrls: ['./add-fruit.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class AddFruitComponent implements OnInit {
  fruit: Fruits = new Fruits();
  fruitJson: string;
  addFruitError: string = "";
  constructor(private addFruitService: AddFruitService, private router: Router) { }

  ngOnInit() {
  }

  SaveFruit() {
    this.fruitJson = JSON.stringify(this.fruit);
    this.addFruitService.SaveFruit(this.fruitJson).toPromise()
    .then(() => {this.router.navigate(['/FruitList']);} )
    
    // .subscribe(
    //   function (x) { },
    //   function (err) {
    //     console.error('There was an error!', err);
    //     this.addFruitError = err;
    //   },
    //   function () {
        
    //   }
    // );
    
  }

  GetNextId() {
    this.fruitJson = JSON.stringify(this.fruit);
    this.addFruitService.SaveFruit(this.fruitJson).toPromise()
    .then(() => {this.router.navigate(['/FruitList']);} )
    
    // .subscribe(
    //   function (x) { },
    //   function (err) {
    //     console.error('There was an error!', err);
    //     this.addFruitError = err;
    //   },
    //   function () {
        
    //   }
    // );
    
  }

}
