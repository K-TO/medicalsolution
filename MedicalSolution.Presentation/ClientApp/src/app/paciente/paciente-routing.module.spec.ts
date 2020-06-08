import { PacienteRoutingModule } from './paciente-routing.module';

describe('PacienteRoutingModule', () => {
  let pacienteRoutingModule: PacienteRoutingModule;

  beforeEach(() => {
    pacienteRoutingModule = new PacienteRoutingModule();
  });

  it('should create an instance', () => {
    expect(pacienteRoutingModule).toBeTruthy();
  });
});
