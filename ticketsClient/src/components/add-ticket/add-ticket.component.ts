import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { TicketService } from '../../services/ticket.service';
import { TicketPostType } from '../../models/ticket-post.model';

import { MatIcon } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';

@Component({
  selector: 'app-add-ticket',
  standalone: true,
  imports: [MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    ReactiveFormsModule],
  templateUrl: './add-ticket.component.html',
  styleUrl: './add-ticket.component.css'
})
export class AddTicketComponent {




  ticketForm!: FormGroup;

  constructor(private fb: FormBuilder, private ticketService: TicketService) { }

  ngOnInit(): void {
    this.ticketForm = this.fb.group({
     
      fullname: ["",Validators.required],
      email: ["",Validators.required],
      description: ["",Validators.required],
      imageUrl: ["",Validators.required]
    });

   
  }

  onSubmit() {
    if (this.ticketForm.valid) {
      const formValues = this.ticketForm.value as TicketPostType;
      
      this.ticketService.addTicket(formValues);
      
    }
  }

 ;

}
