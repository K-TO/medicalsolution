using System.Collections.Generic;
using MedicalSolution.Infraestructure;

namespace MedicalSolution.Services
{
    public interface IDoctorService
    {
        /// <summary>
        /// Get all doctors.
        /// </summary>
        /// <returns></returns>
        List<Doctor> GetAll();

        /// <summary>
        /// Get a doctor using the id.
        /// </summary>
        /// <param name="id">doctor id</param>
        /// <returns></returns>
        Doctor GetById(int id);

        /// <summary>
        /// Create or update a doctor
        /// </summary>
        /// <param name="doctor">Doctor data</param>
        /// <returns></returns>
        bool CreateOrUpdate(Doctor doctor);

        /// <summary>
        /// Delete a doctor
        /// </summary>
        /// <param name="doctor">Doctor id</param>
        /// <returns></returns>
        bool Delete(int doctorId);
    }
}
