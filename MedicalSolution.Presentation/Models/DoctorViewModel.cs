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

    public class AddDoctorViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(ErrorMessage = "El nombre no debe tener mas de 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z ÑÁÉÍÓÚñáéíóú]+$", ErrorMessage = "El campo {0} contiene caracteres inválidos.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(ErrorMessage = "El apellido no debe tener mas de 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z ÑÁÉÍÓÚñáéíóú]+$", ErrorMessage = "El campo {0} contiene caracteres inválidos.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(ErrorMessage = "El apellido no debe tener mas de 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z 0123456789]+$", ErrorMessage = "El campo {0} contiene caracteres inválidos.")]
        public string Credencial { get; set; }

        [Required(ErrorMessage = "La especialidad es obligatoria.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "La especialidad contiene caracteres inválidos.")]
        [Range(1, int.MaxValue, ErrorMessage = "La especialidad seleccionada no es valida.")]
        public int EspecialidadId { get; set; }

        [Required(ErrorMessage = "El hospital es obligatorio.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El hospital contiene caracteres inválidos.")]
        [Range(1, int.MaxValue, ErrorMessage = "El hospital no es valido.")]
        public int HospitalId { get; set; }
    }
}
