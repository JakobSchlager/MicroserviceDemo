import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ITicket } from './model/ticket';

@Injectable({
  providedIn: 'root'
})
export class TicketService {
  baseURL = 'http://localhost:5002/api/tickets';

  constructor(private http: HttpClient) { }

  getAllMTickets()
  {
    return this.http.get<ITicket[]>(this.baseURL);
  }

  postNewTicket(ticket: ITicket)
  {
    return this.http.post<ITicket>(this.baseURL, ticket);
  }

  putUpdateTicket(id: number, ticket: ITicket)
  {
    return this.http.put<ITicket>(this.baseURL + '/' + id, ticket);
  }

}
