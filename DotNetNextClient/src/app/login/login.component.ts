import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model: any = {};
  constructor(public authService: AuthService, private router: Router) { } 

  ngOnInit() {
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log("Logged In Successfully");
    }, error => {
      console.log("Login failed");
    }, () => {
      this.router.navigate(['/landingpage']);
    });
  }

}
