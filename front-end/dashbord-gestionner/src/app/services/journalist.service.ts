import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class JournalistService {
  urlApi = "https://environnementnewsapi.conveyor.cloud/api/Journalist/listJournalist";

  constructor(private http: HttpClient) { }

  getAll() {
    return this.http.get(this.urlApi);
  }
}
