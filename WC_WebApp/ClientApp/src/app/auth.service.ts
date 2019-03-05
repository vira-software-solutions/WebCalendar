import { Injectable } from "@angular/core";
import {HttpClient}from "@angular/common/http"
import {Router} from "@angular/router"

interface ResponseData {
  success: boolean;
  message: string;
}

@Injectable({
  providedIn: "root"
})
export class AuthService {

  constructor(private http:HttpClient,
    private router: Router) { }

  

  getUserDetails(username, password) {
    this.http.get<ResponseData>(`/api/auth/${username}/${password}`).subscribe(data => {
      if (data.success) {
        this.router.navigate(["/admin"]);
      } else {
        window.alert(data.message);
      }
    });
  }
}
