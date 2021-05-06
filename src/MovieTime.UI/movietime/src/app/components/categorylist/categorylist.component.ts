import { Component,Input, OnInit } from '@angular/core';
import { Categories } from '../../models/categories';
@Component({
  selector: 'app-categorylist',
  templateUrl: './categorylist.component.html',
  styleUrls: ['./categorylist.component.css']
})
export class CategorylistComponent implements OnInit {

  @Input() categories:Categories;
  constructor() { }

  ngOnInit(): void {
  }

}
