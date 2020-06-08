import { TestBed, inject } from '@angular/core/testing';

import { PacienteViewService } from './paciente-view.service';

describe('PacienteViewService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PacienteViewService]
    });
  });

  it('should be created', inject([PacienteViewService], (service: PacienteViewService) => {
    expect(service).toBeTruthy();
  }));
});
