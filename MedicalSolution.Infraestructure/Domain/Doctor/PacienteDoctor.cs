using MedicalSolution.Infraestructure.Data;

namespace MedicalSolution.Infraestructure
{
    public class PacienteDoctor : BaseEntity
    {
        public int DoctorId { get; set; }

        public int PacienteId { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}
