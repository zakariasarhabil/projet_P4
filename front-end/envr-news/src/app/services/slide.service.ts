import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SlideService {


  urlApi = "https://environnementnewsapi.conveyor.cloud/api/Article/Articleslide";
  constructor(private http: HttpClient) {}

  getAll() {
    return this.http.get<any>(this.urlApi);
  }
}
