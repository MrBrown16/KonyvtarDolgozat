import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { KolcsonzoComponent } from './kolcsonzo/kolcsonzo.component';
import { KolcsonzesComponent } from './kolcsonzes/kolcsonzes.component';

const routes: Routes = [
  {path:"", component:HomeComponent},
  {path:"kolcsonzok", component:KolcsonzoComponent},
  {path:"kolcsonzes", component:KolcsonzesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
