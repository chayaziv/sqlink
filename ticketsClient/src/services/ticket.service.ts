import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, tap } from 'rxjs';
import { TicketPostType } from '../models/ticket-post.model';
import { HttpClient } from '@angular/common/http';
import { ResponseAPI } from '../models/response-api';
import { TicketType } from '../models/ticket.model';

@Injectable({
  providedIn: 'root'
})
export class TicketService {

 
  private ticketsSubject = new BehaviorSubject<TicketType[]>([]);
  public tickets$: Observable<TicketType[]> =
    this.ticketsSubject.asObservable();

private url='Ticket'
  constructor(private http: HttpClient) { 
    this.loadTickets();
  }

  loadTickets() {

    console.log("load tickets")
    this.http.get<ResponseAPI<TicketType[]>>(this.url).subscribe(
      (response) => {
        this.ticketsSubject.next(response.data);
        console.log('tickets loaded', response.data);
      },
      (error) => {
        console.log('Error loading tickets:', error);
      }
    );
  }

  getTicketById(id: string): Observable<TicketType> {
    return this.http.get<TicketType>(`${this.url}/${id}`);
  }

  addTicket(ticket: TicketPostType) {

    console.log("in add ticket", ticket)
    this.http.post(this.url, ticket).subscribe(
      (response) => {
        console.log('Ticket added successfully:', response);
        alert('Ticket added successfully:')
        this.loadTickets();
      },
      (error) => {
        console.error('Error adding Ticket:', error);
        alert('Error'+ error)
      }
    );
  }
  


}
