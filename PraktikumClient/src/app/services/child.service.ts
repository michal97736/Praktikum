import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import Child from 'src/models/Child';

@Injectable({
  providedIn: 'root'
})
export class ChildService {

  constructor(public http: HttpClient) { }
  baseRouteUrl =`${environment.baseUrl}/Child`
  login(childlog:Child){
    return this.http.post<Child>(this.baseRouteUrl, childlog);
  }
}
