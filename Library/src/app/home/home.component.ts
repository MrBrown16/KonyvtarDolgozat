import { Component } from '@angular/core';
import { BaseService } from '../base.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  books:boolean=true

  constructor(private base:BaseService,private router:Router){
    
  }
  toggleBooks(){
    this.books!=this.books
    this.router.navigate(["/kolcsonzok"])
  }



}
