using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestMASTER_Airflow.Models;

namespace RestMASTER_Airflow.Managers {
    public class MeasureManager : IMeasureManager{

        private static List<Measure> measures = new List<Measure>() {
            new Measure("D3.06", 26.4, 46)
        };

        public IEnumerable<Measure> GetMeasures() {
            return measures.ToList();
        }

        public IEnumerable<Measure> GetMeasureByDate(DateTime day) { //Måske kig på tid hvis ikke virker
            return measures.Where(x => x.Date.Equals(day));
        }

        public void AddMeasure(Measure measure) {
            measures.Add(measure);
        }

        public void DeleteMeasure(int id) {
            measures.Remove(measures.Find(x => x.ID.Equals(id)));
        }
    }
}
