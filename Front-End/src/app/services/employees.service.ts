import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  readonly employeesUrl = 'https://localhost:7005/api';


  constructor(private http: HttpClient) { }

  // employees services
  getEmployees(): Observable<any[]> {
    return this.http.get<any>(this.employeesUrl + 'Employees/get-employee')

  }
}
