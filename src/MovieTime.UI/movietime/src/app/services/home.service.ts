import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Movies } from '../models/movies';
;
const enum endpoint{
    movies='/movies/getmovies'
}

@Injectable({
    providedIn:'root'
})
export class HomeService{
    private URL = "https://localhost:44331/api"
    private longUrl="";
    constructor(private http:HttpClient){

    }
    getMovies():Observable<Movies>{
       this.longUrl = this.URL+endpoint.movies;
      return this.http.get<Movies>(this.longUrl);
    }
}