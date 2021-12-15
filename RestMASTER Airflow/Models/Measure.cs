using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestMASTER_Airflow.Models {
    public class Measure {

        public int ID { get; set; }
        private static int idcount = 0;
        public string Classroom { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public DateTime Date { get; set; }

        public Measure(string classroom, double temp, int hum) {
            ID = idcount++;
            Classroom = classroom;
            Temperature = temp;
            Humidity = hum;
            Date = DateTime.Today;
        }

        public override string ToString() {
            return $"ID: {ID} - Classroom: {Classroom} - Temperature: {Temperature} - Humidity: {Humidity} - Date: {Date}";
        }
    }
}
