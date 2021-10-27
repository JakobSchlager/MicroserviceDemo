import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TicketVerificationComponent } from './ticket-verification.component';

describe('TicketVerificationComponent', () => {
  let component: TicketVerificationComponent;
  let fixture: ComponentFixture<TicketVerificationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TicketVerificationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TicketVerificationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
