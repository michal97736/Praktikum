import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import User from 'src/models/User';

@Injectable({
  providedIn: 'root'
})
export class UserService {


  constructor(public http: HttpClient) { }
  baseRouteUrl = `${environment.baseUrl}/User`
  login(userlog: User){
    return this.http.post<User>(this.baseRouteUrl, userlog);
  }
}
