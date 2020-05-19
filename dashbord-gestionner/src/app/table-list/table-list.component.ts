import { Component, OnInit } from '@angular/core';
import { JournalistService } from 'app/services/journalist.service';

@Component({
  selector: 'app-table-list',
  templateUrl: './table-list.component.html',
  styleUrls: ['./table-list.component.css']
})
export class TableListComponent implements OnInit {

  journalistes: any [] =[];

  constructor(private journalistService : JournalistService) { }

  ngOnInit() {
    this.getjour()
  }
  getjour() {
    this.journalistService.getAll().subscribe((res: any[])=>{
      this.journalistes = res;
      console.log(this.journalistes)
    })
  }

}
