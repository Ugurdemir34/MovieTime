import { Component, OnInit } from '@angular/core';
import { Movies,MoviesEntity } from '../models/movies';
import { HomeService } from '../services/home.service';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit {
    model = {
        left: true,
        middle: false,
        right: false
    };

    focus;
    focus1;
    data:any;
    totalRecords:number;
    page:Number=1;
    paginationLimit;
    movies:MoviesEntity[];
    constructor(private homeservices:HomeService) { 
      this.homeservices.getMovies().subscribe((data:Movies)=>{
          console.log(data.movies);
          this.movies = data.movies;
          this.totalRecords=data.movies.length;
          this.paginationLimit =Math.floor(((this.totalRecords / 3)+1))*10; 
          console.log(this.paginationLimit);
      })
      
    
    }

    ngOnInit() {
    
    }
}
