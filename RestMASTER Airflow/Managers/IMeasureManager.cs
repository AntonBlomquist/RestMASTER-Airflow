using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestMASTER_Airflow.Models;

namespace RestMASTER_Airflow.Managers {
    interface IMeasureManager {
        public IEnumerable<Measure> GetMeasures();

        public IEnumerable<Measure> GetMeasureByDate(DateTime day);
        public void AddMeasure(Measure measure);
        public void DeleteMeasure(int id);
    }
}
