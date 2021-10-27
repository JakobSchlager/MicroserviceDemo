import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { MovieComponent } from './movie/movie.component';
import { PresentationComponent } from './presentation/presentation.component';
import { SeatBookingComponent } from './seat-booking/seat-booking.component';
import { TicketVerificationComponent } from './ticket-verification/ticket-verification.component';

@NgModule({
  declarations: [
    AppComponent,
    MovieComponent,
    PresentationComponent,
    SeatBookingComponent,
    TicketVerificationComponent
  ],
  imports: [
    BrowserModule, 
    FormsModule, 
    HttpClientModule,  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
