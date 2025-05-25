import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';


@Component({
  selector: 'app-menue',
  standalone: true,
  imports: [RouterLink, MatToolbarModule, MatIconModule, MatMenuModule],
  templateUrl: './menue.component.html',
  styleUrl: './menue.component.css'
})
export class MenueComponent {
  
}
