using MedicalSolution.Infraestructure;
using MedicalSolution.Presentation.Models;
using MedicalSolution.Services;
using Microsoft.AspNetCore.Mvc;
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
        public void Post([FromBody] Doctor doctor)
        {
            _doctorService.CreateOrUpdate(doctor);
        }
        #endregion
    }
}
