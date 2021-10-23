import { Component, OnInit } from '@angular/core';
import { IMovie } from './interfaces';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  readonly address: string = `http://localhost`; 
  title = 'kino';
 
  status: number = 100; 
  setStatus(percent: number) {
    this.status = percent; 
  }

  movies: IMovie[] = []; 
  
  ngOnInit(): void {
    
  }
  
}
