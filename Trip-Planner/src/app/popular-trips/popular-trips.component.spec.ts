import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PopularTripsComponent } from './popular-trips.component';

describe('PopularTripsComponent', () => {
  let component: PopularTripsComponent;
  let fixture: ComponentFixture<PopularTripsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [PopularTripsComponent]
    });
    fixture = TestBed.createComponent(PopularTripsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
