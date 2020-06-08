using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MedicalSolution.Presentation.Models
{
    public class DoctorViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Credencial { get; set; }

        public string Especialidad { get; set; }

        public string Hospital { get; set; }
    }

    public class DoctorDropdownViewModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
