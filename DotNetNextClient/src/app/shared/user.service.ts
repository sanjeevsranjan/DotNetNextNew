import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import {Observable} from 'rxjs';
import { map } from 'rxjs/operators';
import { User } from './user.model';

@Injectable()
export class UserService {
  readonly rootUrl = 'https://localhost:44399';
  constructor(private http: HttpClient) { }

  registerUser(user: User) {
    const body: User = {
      UserEmail: user.UserEmail,
      FullName: user.FullName,
      Password: user.Password,
      PhoneNumber: user.PhoneNumber
    }
    return this.http.post(this.rootUrl + '/api/Auth/register', body);
  }


  userAuthentication(user : User) {
    
    var data ='{"Username":"'+user.UserEmail+'", "password":"'+user.Password+'"}';
    var reqHeader = new HttpHeaders({ 'Content-Type': 'application/json'});
    return this.http.post(this.rootUrl + '/api/Token/CreateToken', data, { headers: reqHeader });
  }

  getUserClaims(){
    return  this.http.get(this.rootUrl+'/api/User/GetUserClaims');
   }

   getAllUsers()
   {
     return this.http.get(this.rootUrl+'/api/User/Register')
   }
}
