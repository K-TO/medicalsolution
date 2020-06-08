using MedicalSolution.Infraestructure;
using MedicalSolution.Infraestructure.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalSolution.Services
{
    public class DoctorService : IDoctorService
    {

        #region Members
        private readonly ILogger<DoctorService> _logger;
        private readonly IGenericRepository<Doctor> _repository;
        private IValidationDictionary _validationDictionary;
        //private readonly ILogger _logger;
        #endregion

        #region Ctor
        public DoctorService(IGenericRepository<Doctor> repository, ILogger<DoctorService> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        #endregion

        #region Methods
        public List<Doctor> GetAll()
        {
            try
            {
                return _repository.Getall().ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Concat("Error en DoctorService/GetAll: ", ex.Message));
                _validationDictionary.AddError("Error", "Error al obtener los datos de los doctores, consulte al administrador.");
                throw;
            }
        }

        public Doctor GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Concat("Error en DoctorService/GetById: ", ex.Message));
                _validationDictionary.AddError("Error", "Error al obtener los datos del doctor, consulte al administrador.");
                throw;
            }
        }

        public bool CreateOrUpdate(Doctor doctor)
        {
            try
            {
                bool result = false;
                if (doctor != null)
                {
                    var exist = _repository.GetById(doctor.Id);
                    if (exist != null)
                    {
                        _repository.Update(doctor);
                    }
                    else
                    {
                        _repository.Insert(doctor);
                    }
                    _repository.Save();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Concat("Error en DoctorService/CreateOrUpdate: ", ex.Message));
                //this._validationDictionary.AddError("Error", "Error al modificar los datos del doctor, consulte al administrador.");
                return false;
            }
        }

        public bool Delete(int doctorId)
        {
            try
            {
                bool result = false;
                if (doctorId > 0)
                {
                    var exist = _repository.GetById(doctorId);
                    if (exist != null)
                    {
                        _repository.Delete(exist);
                        result = true;
                    }
                    else
                    {
                        //_logger.LogWarning(string.Format("Se intento eliminar un doctor no existente con id: {0}", doctorId));
                        result = false;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                //_logger.LogError(string.Concat("Error en DoctorService/Delete: ", ex.Message));
                _validationDictionary.AddError("Error", "Error al eliminar los datos del doctor, consulte al administrador.");
                return false;
            }
        }
        #endregion

        #region Validation dictionary
        public void SetValidationDictionary(IValidationDictionary _validationDictionary)
        {
            this._validationDictionary = _validationDictionary;
        }
        #endregion
    }
}
