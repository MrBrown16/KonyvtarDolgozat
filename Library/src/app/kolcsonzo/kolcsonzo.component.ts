import { Component } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-kolcsonzo',
  templateUrl: './kolcsonzo.component.html',
  styleUrls: ['./kolcsonzo.component.css']
})
export class KolcsonzoComponent {

  kolcsonzok!:any

  constructor(private base:BaseService){
    base.getKolcsonzok().subscribe((res:{Id:number,Nev:string,SzulIdo:string}[])=>this.kolcsonzok=res)
  }


}
