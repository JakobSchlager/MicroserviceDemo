import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IMovie } from '../model/movie';

@Component({
  selector: 'movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.scss']
})
export class MovieComponent implements OnInit {

  @Input() movie!: IMovie;
  @Output() pickedMovie = new EventEmitter<number>();

  constructor() { }

  ngOnInit(): void {
  }

  selected()
  {
    this.pickedMovie.emit(this.movie.id);
  }

}
