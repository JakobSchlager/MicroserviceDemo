import { Component, OnInit } from '@angular/core';
import { IMovie } from './model/movie';
import { IPresentation } from './model/presentation';
import { MovieService } from './movie.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'kino';
  status: number = 0; 
  movies: IMovie[] = []; 
  presentation: IPresentation[] = []; 

  constructor(private movieService: MovieService)
  {

  }
  
  ngOnInit(): void {
    this.movieService.getAllMovies().subscribe(x => this.movies = x);
  }

  pickMovie(id: number) {
    console.log(id);
    this.setStatus(33.33);
    this.movieService.getPresentationsOfMovie(id).subscribe(x => this.presentation = x);
  }


  setStatus(percent: number) {
    this.status = percent; 
  }

  backStatus()
  {
    this.status = this.status - 33.33;
  }
  
}
