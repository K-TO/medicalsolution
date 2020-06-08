using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSolution.Framework.ContractModels
{
    public class Paciente
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string NumeroSeguro { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }
    }
}
