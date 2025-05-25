import { Routes } from '@angular/router';
import { AllTicketsComponent } from '../components/all-tickets/all-tickets.component';
import { AddTicketComponent } from '../components/add-ticket/add-ticket.component';
import { TicketViewComponent } from '../components/ticket-view/ticket-view.component';

export const routes: Routes = [

    { path: 'admin-tickets', component: AllTicketsComponent },
    { path: 'add-ticket', component: AddTicketComponent },
    { path:'view-ticket', component: TicketViewComponent },

 
];
