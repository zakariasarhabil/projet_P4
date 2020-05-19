import { CardService } from './../../services/card.service';
import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-side-news",
  templateUrl: "./side-news.component.html",
  styleUrls: ["./side-news.component.css"]
})
export class SideNewsComponent implements OnInit {
  cards: any[] = [];
  constructor(private cardService: CardService) {}



  ngOnInit() {
    this.getCard()
  }

  getCard() {
    this.cardService.getAll()
        .subscribe((res: any[]) => {

          this.cards = res;

        console.log(this.cards)
        })
  }
}
