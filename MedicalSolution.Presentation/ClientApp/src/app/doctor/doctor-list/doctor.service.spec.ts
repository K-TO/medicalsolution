import { TestBed, inject } from '@angular/core/testing';

import { DoctorService } from './doctor.service';

describe('DoctorListService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DoctorService]
    });
  });

  it('should be created', inject([DoctorService], (service: DoctorService) => {
    expect(service).toBeTruthy();
  }));
});
