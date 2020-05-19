import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
@Injectable({
  providedIn: "root"
})
export class CardService {

  urlApi = "https://environnementnewsapi.conveyor.cloud/api/Article/Article";
  constructor(private http: HttpClient) {}

  getAll() {
    return this.http.get(this.urlApi);
  }
  //
}


