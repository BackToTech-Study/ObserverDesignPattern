import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TemperatureServiceService {

  private temperature: Subject<number> = new Subject<number>();
  public temperature$: Observable<number>= this.temperature.asObservable();

  constructor() { }

  public updateTemperature() {
    //this replaces the setTemperature from the uml diagram
    console.log("service updateTemperature call")
    this.temperature.next(Math.floor(Math.random()*35))
  }
}
