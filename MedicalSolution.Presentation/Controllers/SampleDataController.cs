using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalSolution.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSolution.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        #region Members
        private static string[] Summaries = new[]
       {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IDoctorService _doctorService;
        #endregion

        #region Ctor
        public SampleDataController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        #endregion

        #region Methods
        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var doctores = _doctorService.GetAll();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        } 
        #endregion

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
