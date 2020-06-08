import { TestBed, inject } from '@angular/core/testing';

import { DoctorViewService } from './doctor-view.service';

describe('DoctorViewService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DoctorViewService]
    });
  });

  it('should be created', inject([DoctorViewService], (service: DoctorViewService) => {
    expect(service).toBeTruthy();
  }));
});
