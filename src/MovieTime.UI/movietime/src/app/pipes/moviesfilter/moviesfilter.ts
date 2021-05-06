import { Pipe, PipeTransform } from '@angular/core';
import { Movies, MoviesEntity } from '../../models/movies';

@Pipe({
  name:"movieFilter"
})
export class MoviesFilterPipe implements PipeTransform{
  transform(movies: MoviesEntity[],searchTerm:string):MoviesEntity[]{
    if(!movies || !searchTerm)
    {
      return movies;
    }
    return movies.filter(movies=>movies.title.toLocaleLowerCase().includes(searchTerm.toLocaleLowerCase()));
  }
}
