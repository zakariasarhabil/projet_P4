import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/Forms";
import { NgModule } from "@angular/core";

import { HttpClientModule } from '@angular/common/http';


import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { NavBarComponent } from "./component/nav-bar/nav-bar.component";
import { SliderComponent } from "./component/slider/slider.component";
import { SideNewsComponent } from "./component/side-news/side-news.component";
import { BodyArticlesComponent } from "./component/body-articles/body-articles.component";
import { FooterComponent } from "./component/footer/footer.component";
import { ContactComponent } from "./component/contact/contact.component";
import { HomeComponent } from "./component/home/home.component";
import { ArticleComponent } from "./component/article/article.component";

// import { HttpClientModule } from "@angular/common/http";

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    SliderComponent,
    SideNewsComponent,
    BodyArticlesComponent,
    FooterComponent,
    ContactComponent,
    HomeComponent,
    ArticleComponent
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule,HttpClientModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
