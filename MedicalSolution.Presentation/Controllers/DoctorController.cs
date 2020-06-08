using MedicalSolution.Infraestructure;
using MedicalSolution.Infraestructure.Domain.Common;
using MedicalSolution.Presentation.Models;
using MedicalSolution.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace MedicalSolution.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        #region Members
        private readonly IDoctorService _doctorService;
        #endregion

        #region Ctor
        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        #endregion

        #region Methods
        // GET: api/Doctor
        [HttpGet]
        public IEnumerable<DoctorViewModel> Get()
        {
            List<DoctorViewModel> result = new List<DoctorViewModel>();
            var doctores = _doctorService.GetAll();
            if (doctores != null && doctores.Any())
            {
                result.AddRange(doctores.Select(x => new DoctorViewModel() {
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Credencial = x.Credencial,
                    Especialidad = x.Especialidad?.Nombre,
                    Hospital = x.Hospital?.Nombre,
                    Id = x.Id
                }));
            }
            return result;
        }

        ////GET: api/getDoctors/
        //[HttpGet(Name = "GetDoctors")]
        //public IEnumerable<DoctorDropdownViewModel> GetDoctors()
        //{
        //    List<DoctorDropdownViewModel> result = new List<DoctorDropdownViewModel>();
        //    var doctores = _doctorService.GetAll();
        //    if (doctores != null && doctores.Any())
        //    {
        //        result.AddRange(doctores.Select(x => new DoctorDropdownViewModel()
        //        {
        //            Id = x.Id,
        //            Nombre = string.Concat(x.Nombres, " ", x.Apellidos)
        //        }));
        //    }
        //    return result;
        //}

        // GET: api/Doctor/5
        [HttpGet("{id}")]
        public DoctorViewModel Get(int id)
        {
            var doctor = _doctorService.GetById(id);
            if (doctor != null)
            {
                var doctorView = new DoctorViewModel();
                PropertyCopy.Copy(doctor, doctorView);
                return doctorView;
            }
            return null;
        }

        // POST: api/Doctor
        [HttpPost]
        public IActionResult Post([FromBody] AddDoctorViewModel doctor)
        {
            JsonDefaultResponseModel response = new JsonDefaultResponseModel()
            {
                IsError = true
            };
            if (ModelState.IsValid)
            {
                Doctor doctorModel = new Doctor();
                PropertyCopy.Copy(doctor, doctorModel);
                if (_doctorService.CreateOrUpdate(doctorModel))
                {
                    response.IsError = false;
                    response.Message = "Doctor creado exitosamente.";
                }
            }
            else
            {
                response.Message = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
            }
            return Ok(JsonConvert.SerializeObject(response));
        }
        #endregion
    }
}
