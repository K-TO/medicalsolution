using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalSolution.Framework.ContractModels;
using MedicalSolution.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSolution.API.Controllers
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
            List<Paciente> pacientes = new List<Paciente>();
            var patients = _pacienteService.GetAll();

            return pacientes;
        }

        // GET: api/Paciente/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Paciente
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Paciente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        } 
        #endregion
    }
}
