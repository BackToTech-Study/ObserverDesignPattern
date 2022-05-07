import { Component } from '@angular/core';
import { Subscription } from 'rxjs';
import { TemperatureServiceService } from './services/temperature-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'AngularObserverDemo';
  currentTemperature: number = 0;
  tempServiceSubscription: Subscription | undefined;

  constructor(private tempService:  TemperatureServiceService) {}

  ngOnInit() {
    this.tempServiceSubscription = this.tempService.temperature$.subscribe((newTemperature) => {
      console.log(`New temperature = ${newTemperature}`);
      this.currentTemperature = newTemperature;
    })
  }

  ngOnDestroy() {
    if (this.tempServiceSubscription) {
      this.tempServiceSubscription.unsubscribe();
    }
  }

  public updateTemperature() {
    console.log("local updateTemperature call")
    this.tempService.updateTemperature();
  }

}
