import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';

import { HomeComponent } from './home.component';
import {MoviecardComponent} from '../components/moviecard/moviecard.component';
import {MoviecarouselComponent} from '../components/moviecarousel/moviecarousel.component';
import { SectionsModule } from '../sections/sections.module';
import {NgxPaginationModule} from 'ngx-pagination'
@NgModule({
    imports: [
        CommonModule,
        BrowserModule,
        FormsModule,
        RouterModule,
        SectionsModule,
        NgbModule,
        NgxPaginationModule
     
    ],
    declarations: [ HomeComponent,MoviecardComponent,MoviecarouselComponent ],
    exports:[ HomeComponent ],
    providers: []
})
export class HomeModule { }
