using MedicalSolution.Infraestructure;
using MedicalSolution.Infraestructure.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalSolution.Services
{
    public class PacienteService: IPacienteService
    {
        #region Members
        private readonly IGenericRepository<Paciente> _repository;
        private IValidationDictionary _validationDictionary;
        private readonly ILogger _logger;
        #endregion

        #region Ctor
        public PacienteService(IGenericRepository<Paciente> repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods
        public List<Paciente> GetAll()
        {
            try
            {
                return _repository.Getall().ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Concat("Error en PacienteService/GetAll: ", ex.Message));
                _validationDictionary.AddError("Error", "Error al obtener los datos de los pacientes, consulte al administrador.");
                throw;
            }
        }

        public Paciente GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Concat("Error en PacienteService/GetById: ", ex.Message));
                _validationDictionary.AddError("Error", "Error al obtener los datos del paciente, consulte al administrador.");
                throw;
            }
        }

        public bool CreateOrUpdate(Paciente paciente)
        {
            try
            {
                bool result = false;
                if (paciente != null)
                {
                    var exist = _repository.GetById(paciente.Id);
                    if (exist != null)
                        _repository.Update(paciente);
                    else
                        _repository.Insert(paciente);
                    _repository.Save();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Concat("Error en PacienteService/CreateOrUpdate: ", ex.Message));
                _validationDictionary.AddError("Error", "Error al modificar los datos del paciente, consulte al administrador.");
                return false;
            }
        }

        public bool Delete(int pacienteId)
        {
            try
            {
                bool result = false;
                if (pacienteId > 0)
                {
                    var exist = _repository.GetById(pacienteId);
                    if (exist != null)
                        _repository.Delete(exist);
                    else
                    {
                        _logger.LogWarning(string.Format("Se intento eliminar un paciente no existente con id: {0}", pacienteId));
                        return false;
                    }
                    _repository.Save();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Concat("Error en PacienteService/Delete: ", ex.Message));
                _validationDictionary.AddError("Error", "Error al eliminar los datos del paciente, consulte al administrador.");
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
