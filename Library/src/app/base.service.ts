import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Kolcsonzes } from './Kolcsonzes';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  private kolcsonzoUrl = "http://localhost:5002/api/Kolcsonzoes"
  private kolcsonzesUrl = "http://localhost:5002/api/Kolcsonzes"

  private kolcsonzok:BehaviorSubject<{Id:number,Nev:string,SzulIdo:string,kolcsonzesek:Kolcsonzes[]}[]> = new BehaviorSubject([{Id:0,Nev:"",SzulIdo:"",kolcsonzesek:[new Kolcsonzes]}])
  private kolcsonzesek:BehaviorSubject<Kolcsonzes[]> = new BehaviorSubject([new Kolcsonzes])
  constructor(private http:HttpClient) {
    this.loadKolcsonzok()
    this.loadKolcsonzesek()
   }


   loadKolcsonzok(){
     this.http.get(this.kolcsonzoUrl).subscribe((res:any)=>{
      console.log("kolcsonzok: ",res)
      this.kolcsonzok.next(res)
    })
  }
  getKolcsonzo(id:any){
    return this.http.get(this.kolcsonzoUrl+id)
  }
  getKolcsonzes(id:any){
    return this.http.get(this.kolcsonzesUrl+id)
  }
  loadKolcsonzesek(){
    this.http.get(this.kolcsonzesUrl).subscribe((res:any)=>{
      console.log("kolcsonzesek: ",res)
      this.kolcsonzesek.next(res)
    })
  }


  postKolcsonzes(kolcsonzes:Kolcsonzes){
    this.http.post(this.kolcsonzoUrl,kolcsonzes).subscribe(console.log)
  }

  putKolcsonzes(kolcsonzes:Kolcsonzes){
    this.http.put(this.kolcsonzesUrl+kolcsonzes.Id,kolcsonzes).subscribe(console.log)
  }
  deleteKolcsonzes(id:any){
    this.http.delete(this.kolcsonzesUrl+id).subscribe(console.log);
    
  }






  getKolcsonzok(){
    return this.kolcsonzok
  }
  getKolcsonzesek(){
    return this.kolcsonzesek
  }


}
