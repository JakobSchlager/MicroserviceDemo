import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IRoom } from './model/room';
import { ISeat } from './model/seat';

@Injectable({
  providedIn: 'root'
})
export class RoomService {
  baseURLroom = 'http://localhost:5001/api/room';
  baseURLseat = 'http://localhost:5001/api/seat';


  constructor(private http: HttpClient) { }

  getAllRooms()
  {
    return this.http.get<IRoom[]>(this.baseURLroom);
  }

  getOneRoom(id: number)
  {
    return this.http.get<IRoom>(this.baseURLroom + '/' + id);
  }


  getAllSeats()
  {
    return this.http.get<ISeat[]>(this.baseURLseat);
  }

  getOneSeat(id: number)
  {
    return this.http.get<ISeat>(this.baseURLseat + '/' + id);
  }
}
