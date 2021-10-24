import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IMovie } from './model/movie';
import { IPresentation } from './model/presentation';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  baseURL = 'http://localhost:5000/api/movies';

  constructor(private http: HttpClient) { }

  getAllMovies()
  {
    return this.http.get<IMovie[]>(this.baseURL);
  }

  getOneMovie(id: number)
  {
    return this.http.get<IMovie>(this.baseURL + '/' + id);
  }

  getPresentationsOfMovie(id: number)
  {
    return this.http.get<IPresentation[]>(this.baseURL + '/' + id + '/presentations');
  }


}
