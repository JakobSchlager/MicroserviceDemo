import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { RoomService } from '../room.service';
import { ISeat } from '../model/seat';
import { MovieService } from '../movie.service';
import { IMovie } from '../model/movie';
import { IPresentation } from '../model/presentation';
import { IRoom } from '../model/room';
import { ITicket } from '../model/ticket';

@Component({
  selector: 'seat-booking',
  templateUrl: './seat-booking.component.html',
  styleUrls: ['./seat-booking.component.scss']
})
export class SeatBookingComponent implements OnInit {

  @Input() roomId!: number;
  @Input() movieId!: number;
  @Input() presentationId!: number;

  @Output() result = new EventEmitter<ITicket[]>();

  seats: ISeat[][] = [];
  selectedSeats: number[] = [];
  diable: boolean = true;
  movie!: IMovie;
  presentation!: IPresentation;
  name: string = '';

  constructor(private roomService: RoomService, private movieService: MovieService) { }

 

  ngOnInit(): void {
    this.roomService.getAllSeats().subscribe(x => this.initSeats(x.filter(y => y.roomId == this.roomId)));
    this.movieService.getOneMovie(this.movieId).subscribe(x => this.movie = x);
    this.movieService.getPresentationsOfMovie(this.movieId).subscribe(x => this.presentation = x.filter(y => y.id == this.presentationId)[0]);
  }

  buy()
  {
    console.log(this.name.length);
    if(this.name.length > 0)
    {
      let result: ITicket[] = [];

      this.selectedSeats.forEach(x => result.push({id: 0, presentationId: this.presentationId, seatId: x, customerName: this.name}));
      
      this.result.emit(result);
    }
    else{
      alert("Name is missing!");
    }

  }

  seatSelected(id: number)
  {
    //console.log(id);
    let idx = this.selectedSeats.indexOf(id)
    //console.log( 'idx: ' + idx);
    if(idx > -1)
    {
      this.selectedSeats.splice(idx, 1);
      if(this.selectedSeats.length < 1)
      {
        this.diable = true;
      }
    }
    else{
      this.selectedSeats.push(id);
      this.diable = false;
    }
    //console.log('selectedSeats length: ' + this.selectedSeats.length)
    //console.log('selectedSeats: ' + this.selectedSeats);
    //console.log('disable: ' + this.diable);
  }

  initSeats(temp: ISeat[])
  {
    let idx = 0;
    
    for (let i = 0; i < temp.length/5; i++) {
      let row : ISeat[] = [];
      for (let y = 0; y < 5; y++) {
        row[y] = temp[idx];
        
        idx++;
      }
      this.seats[i] = row;
    }
  }

}
