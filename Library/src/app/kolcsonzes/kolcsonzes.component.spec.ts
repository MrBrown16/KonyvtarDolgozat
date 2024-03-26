import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KolcsonzesComponent } from './kolcsonzes.component';

describe('KolcsonzesComponent', () => {
  let component: KolcsonzesComponent;
  let fixture: ComponentFixture<KolcsonzesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [KolcsonzesComponent]
    });
    fixture = TestBed.createComponent(KolcsonzesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
