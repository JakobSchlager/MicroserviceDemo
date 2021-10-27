import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ITicket } from './model/ticket';

@Injectable({
  providedIn: 'root'
})
export class TicketService {
  baseURL = 'http://localhost:5003/api/tickets';

  constructor(private http: HttpClient) { }

  getAllTickets()
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
