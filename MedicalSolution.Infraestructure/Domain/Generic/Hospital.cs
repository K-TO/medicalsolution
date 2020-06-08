using MedicalSolution.Infraestructure.Data;

namespace MedicalSolution.Infraestructure
{
    public class Hospital : BaseEntity
    {
        public string Nombre { get; set; }

        public string Direccion { get; set; }
    }
}
