import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoviecarouselComponent } from './moviecarousel.component';

describe('MoviecarouselComponent', () => {
  let component: MoviecarouselComponent;
  let fixture: ComponentFixture<MoviecarouselComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MoviecarouselComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MoviecarouselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
