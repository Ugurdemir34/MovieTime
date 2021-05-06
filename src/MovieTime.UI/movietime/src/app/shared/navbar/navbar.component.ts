import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd, NavigationStart } from '@angular/router';
import { Location, PopStateEvent } from '@angular/common';
import { CategoryService } from 'src/app/services/category.service';
import { Categories, CategoriesEntity } from 'src/app/models/categories';
import { Movies, MoviesEntity } from 'src/app/models/movies'
import { HomeService } from 'src/app/services/home.service';
import { FormControl } from '@angular/forms';
import {map, startWith} from 'rxjs/operators';
import {Observable} from 'rxjs';
@Component({
    selector: 'app-navbar',
    templateUrl: './navbar.component.html',
    styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {
    public isCollapsed = true;
    private lastPoppedUrl: string;
    private yScrollStack: number[] = [];
    categories:CategoriesEntity[];
    movies:MoviesEntity[];
    keyword = 'title';
    data = [
       {
         id: 1,
         name: 'Usa'
       },
       {
         id: 2,
         name: 'England'
       }
    ];
  
    searchedMovies:MoviesEntity[];
    constructor(public location: Location, private router: Router,private categoryService:CategoryService,private movieService:HomeService) {
        this.categoryService.getCategories().subscribe((resp:Categories)=>{
            this.categories = resp.categories;
        })
        this.movieService.getMovies().subscribe((resp:Movies) =>{
            this.movies = resp.movies;
           
        })
    }
  
  
    selectEvent(item) {
      // do something with selected item
    }
  
    onChangeSearch(val: string) {
      // fetch remote data from here
      // And reassign the 'data' which is binded to 'data' property.
    }
    
    onFocused(e){
      // do something when input is focused
    }
   
    ngOnInit() {      
      this.router.events.subscribe((event) => {
        this.isCollapsed = true;
        if (event instanceof NavigationStart) {
           if (event.url != this.lastPoppedUrl)
               this.yScrollStack.push(window.scrollY);
       } else if (event instanceof NavigationEnd) {
           if (event.url == this.lastPoppedUrl) {
               this.lastPoppedUrl = undefined;
               window.scrollTo(0, this.yScrollStack.pop());
           } else
               window.scrollTo(0, 0);
       }
     });
     this.location.subscribe((ev:PopStateEvent) => {
         this.lastPoppedUrl = ev.url;
     });
    }

    isHome() {
        var titlee = this.location.prepareExternalUrl(this.location.path());

        if( titlee === '#/home' ) {
            return true;
        }
        else {
            return false;
        }
    }
    isDocumentation() {
        var titlee = this.location.prepareExternalUrl(this.location.path());
        if( titlee === '#/documentation' ) {
            return true;
        }
        else {
            return false;
        }
    }
}
