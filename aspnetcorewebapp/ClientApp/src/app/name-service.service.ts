import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class NameService {
  private headers: HttpHeaders;
  private accessPointUrl: string = 'https://localhost:44373/api/name';

  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  public get() {
    // Get all names
    return this.http.get(this.accessPointUrl, { headers: this.headers });
  }
}
