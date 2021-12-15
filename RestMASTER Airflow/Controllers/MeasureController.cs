using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestMASTER_Airflow.Models;
using RestMASTER_Airflow.Managers;

namespace RestMASTER_Airflow.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class MeasureController : ControllerBase {
        // GET: api/<MeasureController>
        private readonly IMeasureManager measureManager = new MeasureManager();
        [HttpGet]
        public IEnumerable<Measure> GetAll() {
            return measureManager.GetMeasures().ToList();
        }

        // GET ALL FROM SPECIFIC DATE
        [HttpGet("{date}")]
        public IEnumerable<Measure> GetByDate(DateTime date) {
            return measureManager.GetMeasureByDate(date);
        }

        // POST api/<MeasureController>
        [HttpPost("{classroom}/{temp}/{hum}")]
        public void Post(string classroom, double temp, int hum) {
            measureManager.AddMeasure(new Measure(classroom, temp, hum));
        }

        // DELETE api/<MeasureController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
            measureManager.DeleteMeasure(id);
        }
    }
}
