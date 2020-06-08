using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MedicalSolution.Presentation.Models
{
    public class PacienteViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NumeroSeguro { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Direccion { get; set; }
    }

    public class PacienteDropdownViewModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
