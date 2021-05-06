import { Component, Input, OnInit } from '@angular/core';
import { Movies } from '../models/movies';

@Component({
  selector: 'app-sections',
  templateUrl: './sections.component.html',
  styleUrls: ['./sections.component.css']
})
export class SectionsComponent implements OnInit {
  focus;
  focus1; 
  constructor() { }

  ngOnInit() {
  }

}
