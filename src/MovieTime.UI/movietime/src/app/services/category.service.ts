import { Categories } from '../models/categories';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';;
const enum endpoint{
    categories='/categories/getcategories'
}

@Injectable({
    providedIn:'root'
})
export class CategoryService{
    private URL = "https://localhost:44331/api"
    private longUrl="";
    constructor(private http:HttpClient){

    }
    getCategories():Observable<Categories>{
       this.longUrl = this.URL+endpoint.categories;
      return this.http.get<Categories>(this.longUrl);
    }
}