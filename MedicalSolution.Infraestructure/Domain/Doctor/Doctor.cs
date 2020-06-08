using MedicalSolution.Infraestructure.Data;
using System;

namespace MedicalSolution.Infraestructure
{
    public class Doctor : BaseEntity
    {
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public int EspecialidadId { get; set; }

        public string Credencial { get; set; }

        public int HospitalId { get; set; }

        public virtual Especialidad Especialidad { get; set; }

        public virtual Hospital Hospital { get; set; }
    }
}
