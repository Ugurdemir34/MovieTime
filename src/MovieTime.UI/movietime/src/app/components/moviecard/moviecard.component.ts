import { Component, Input, OnInit } from '@angular/core';
import { Movies } from 'src/app/models/movies';

@Component({
  selector: 'app-moviecard',
  templateUrl: './moviecard.component.html',
  styleUrls: ['./moviecard.component.css']
})
export class MoviecardComponent implements OnInit {

  @Input() movie:Movies;
  constructor() { }

  ngOnInit(): void {
  }

}
