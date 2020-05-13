import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddFruitComponent } from './add-fruit/add-fruit.component';
import { FruitListComponent } from './fruit-list/fruit-list.component';
import { PageNotFoundComponent } from './others/page-not-found/page-not-found.component';

const routes: Routes = [

  {path:'AddFruit',component:AddFruitComponent},
  {path:'FruitList',component:FruitListComponent},
  { path: '', redirectTo: '/FruitList', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
