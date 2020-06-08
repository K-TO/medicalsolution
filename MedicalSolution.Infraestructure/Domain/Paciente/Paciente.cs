using MedicalSolution.Infraestructure.Data;
using System;

namespace MedicalSolution.Infraestructure
{
    public class Paciente : BaseEntity
    {
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string NumeroSeguro { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string CodigoPostal { get; set; }
    }
}
