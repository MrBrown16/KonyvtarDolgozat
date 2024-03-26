import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KolcsonzoComponent } from './kolcsonzo.component';

describe('KolcsonzoComponent', () => {
  let component: KolcsonzoComponent;
  let fixture: ComponentFixture<KolcsonzoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [KolcsonzoComponent]
    });
    fixture = TestBed.createComponent(KolcsonzoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
