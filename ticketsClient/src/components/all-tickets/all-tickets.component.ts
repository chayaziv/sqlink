import { Component, OnInit } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatTableModule } from '@angular/material/table';
import { CommonModule } from '@angular/common';
import { TicketService } from '../../services/ticket.service';
import { TicketType } from '../../models/ticket.model';
@Component({
  selector: 'app-all-tickets',
  standalone: true,
  imports: [MatCardModule,
    MatButtonModule,
    MatTableModule,
    MatIconModule,
    MatToolbarModule,
    CommonModule,],
  templateUrl: './all-tickets.component.html',
  styleUrl: './all-tickets.component.css'
})
export class AllTicketsComponent implements OnInit {

  tickets:TicketType[]=[];

  displayedColumns: string[] = [
    "ticketId",
    "fullName",
    "email",
    // "statusId",
    // "description",
    //  "summary",
    // "imageUrl",
    // "solution"
  ];

  /**
   *
   */
  constructor(private ticketService: TicketService) {
   
    
  }

  ngOnInit(): void {
    this.ticketService.tickets$.subscribe((tickets) => {
      this.tickets=tickets;
    });

    this.ticketService.loadTickets();
  }
  onSave(t:TicketType) {
    //קריאה לשרת דרך ה SERVICE ...
    
  }

  onDelete(){
     //קריאה לשרת דרך ה SERVICE ...
  }

  
}
