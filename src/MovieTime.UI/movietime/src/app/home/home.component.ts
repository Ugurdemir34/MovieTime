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
    slides = [
        {img: "http://placehold.it/350x350/000000"},
        {img: "http://placehold.it/350x350/111111"},
        {img: "http://placehold.it/350x350/333333"},
        {img: "http://placehold.it/350x350/666666"},
        {img: "http://placehold.it/350x350/666666"},
        {img: "http://placehold.it/350x350/666666"},
        {img: "http://placehold.it/350x350/666666"},
        {img: "http://placehold.it/350x350/666666"},
        {img: "http://placehold.it/350x350/666666"},
      ];
      slideConfig = {"slidesToShow": 4, "slidesToScroll": 1,'responsive': 
        [
            {
                'breakpoint': 400,
                'settings': {'slidesToShow': 1}            
            },
            {
                'breakpoint': 500,
                'settings': {'slidesToShow': 2}
            },
            {
                'breakpoint':750,
                'settings':{'slidesToShow':2}
            },
            {
                'breakpoint':800,
                'settings':{'slidesToShow':3}
            }
    ]};
    constructor(private homeservices:HomeService) { 
      this.homeservices.getMovies().subscribe((data:Movies)=>{
          console.log(data.movies);
          this.movies = data.movies;
          this.totalRecords=data.movies.length;
          this.paginationLimit =Math.round(((this.totalRecords / 6)))*10; 
          console.log(this.paginationLimit);
      })
      
    
    }

    ngOnInit() {
    
    }
}
