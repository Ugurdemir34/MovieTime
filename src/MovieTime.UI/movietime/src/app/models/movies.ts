export interface Movies {
    movies?: (MoviesEntity)[] | null;
  }
  export interface MoviesEntity {
    title: string;
    director: string;
    date: string;
    imdb: number;
    actors: string;
    thumbnail: string;
    categories?: (CategoriesEntityOrTagsEntityOrGenresEntity)[] | null;
    tags?: (CategoriesEntityOrTagsEntityOrGenresEntity)[] | null;
    genres?: (CategoriesEntityOrTagsEntityOrGenresEntity)[] | null;
    comments?: (null)[] | null;
    admin: Admin;
    id: string;
    description: string;
    creationDate: string;
  }
  export interface CategoriesEntityOrTagsEntityOrGenresEntity {
    name: string;
    id: string;
    description: string;
    creationDate: string;
  }
  export interface Admin {
    name: string;
    userName: string;
    password: string;
    id: string;
    description: string;
    creationDate: string;
  }
  