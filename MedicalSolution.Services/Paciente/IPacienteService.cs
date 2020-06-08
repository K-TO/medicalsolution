using MedicalSolution.Infraestructure;
using System.Collections.Generic;

namespace MedicalSolution.Services
{
    public interface IPacienteService
    {
        /// <summary>
        /// Get all patients.
        /// </summary>
        /// <returns></returns>
        List<Paciente> GetAll();

        /// <summary>
        /// Get a patient using the id.
        /// </summary>
        /// <param name="id">patient id</param>
        /// <returns></returns>
        Paciente GetById(int id);

        /// <summary>
        /// Create or update a patient
        /// </summary>
        /// <param name="patient">Paciente data</param>
        /// <returns></returns>
        bool CreateOrUpdate(Paciente patient);

        /// <summary>
        /// Delete a patient
        /// </summary>
        /// <param name="patientid">Paciente id</param>
        /// <returns></returns>
        bool Delete(int patientid);
    }
}
