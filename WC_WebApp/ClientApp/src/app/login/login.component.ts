import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  username: string;
  password: string;

  constructor(private auth: AuthService){

  }

  ngOnInit() {
  }

  loginUser(event) {
    event.preventDefault();

    this.auth.getUserDetails(
      this.username,
      this.password);
  }
}
