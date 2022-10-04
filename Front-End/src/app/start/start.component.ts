import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Observable } from 'rxjs';
import { EmployeeService } from '../services/employees.service';
import { DialogAskModeComponent } from '../dialog-ask-mode/dialog-ask-mode.component'

@Component({
  selector: 'app-start',
  templateUrl: './start.component.html',
  styleUrls: ['./start.component.css']

})

export class StartComponent implements OnInit {
  constructor( public dialog: MatDialog, private service : EmployeeService){}
  employeeList$ : Observable<any[]>;
  ngOnInit(): void {
  }


  
  public onOpenDialog(){
    this.dialog.open(DialogAskModeComponent , { panelClass: 'custom-container' });
  }
}
