using MedicalSolution.Infraestructure;
using MedicalSolution.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MedicalSolution.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        #region Members
        private readonly IPacienteService _pacienteService;
        #endregion

        #region Ctor
        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }
        #endregion

        #region Methods
        // GET: api/Paciente
        [HttpGet]
        public IEnumerable<Paciente> Get()
        {
            return _pacienteService.GetAll();
        }

        // GET: api/Paciente/5
        [HttpGet("{id}")]
        public Paciente Get(int id)
        {
            return _pacienteService.GetById(id);
        }

        // POST: api/Paciente
        [HttpPost]
        public void Post([FromBody] Paciente paciente)
        {
            _pacienteService.CreateOrUpdate(paciente);
        }

        // PUT: api/Paciente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Paciente paciente)
        {
            _pacienteService.CreateOrUpdate(paciente);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _pacienteService.Delete(id);
        } 
        #endregion
    }
}
