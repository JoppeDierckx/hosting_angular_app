import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActiviteitComponent } from './activiteit.component';

describe('ActiviteitComponent', () => {
  let component: ActiviteitComponent;
  let fixture: ComponentFixture<ActiviteitComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [ActiviteitComponent]
    });
    fixture = TestBed.createComponent(ActiviteitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
