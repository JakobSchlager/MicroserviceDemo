import { Component, Input, OnInit } from '@angular/core';
import { IMovie } from '../model/movie';
import { IPresentation } from '../model/presentation';
import { IRoom } from '../model/room';
import { ITicket } from '../model/ticket';
import { MovieService } from '../movie.service';
import { RoomService } from '../room.service';

@Component({
  selector: 'ticket-verification',
  templateUrl: './ticket-verification.component.html',
  styleUrls: ['./ticket-verification.component.scss']
})
export class TicketVerificationComponent implements OnInit {
  @Input() ticket!: ITicket;

  movie!: IMovie;
  room!: IRoom;
  presentation!: IPresentation;

  constructor(private movieService: MovieService, private roomService: RoomService) { }

  ngOnInit(): void {
    this.movieService.getSinglePresentation(this.ticket.presentationId).subscribe(x => this.movieService.getOneMovie(x.movieId).subscribe(y => this.movie = y));
    this.movieService.getSinglePresentation(this.ticket.presentationId).subscribe(x => this.roomService.getOneRoom(x.roomId).subscribe(y => this.room = y));
    this.movieService.getSinglePresentation(this.ticket.presentationId).subscribe(x => this.presentation = x);
  }

}
