import { SlideService } from './../../services/slide.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css']
})
export class SliderComponent implements OnInit {

  slides: any []= [];

  constructor(private slideService: SlideService) { }

  ngOnInit() {
    this.getCardSlide()
  }

  getCardSlide() {
    this.slideService.getAll().subscribe((res:[]) =>{
      this.slides = res;
      console.log("slide" +this.slides)
    })

  }

}
