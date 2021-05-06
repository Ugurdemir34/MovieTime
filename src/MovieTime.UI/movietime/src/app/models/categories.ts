export interface Categories {
    categories?: (CategoriesEntity)[] | null;
  }
  export interface CategoriesEntity {
    name: string;
    id: string;
    description: string;
    creationDate: string;
  }
