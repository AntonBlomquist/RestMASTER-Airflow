using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestMASTER_Airflow.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestMASTER_Airflow.Models;

namespace RestMASTER_Airflow.Managers.Tests {
    [TestClass]
    public class MeasureManagerTests {

        private MeasureManager _man;
        
        [TestInitialize]
        public void Startup() {
            _man = new MeasureManager();
            _man.AddMeasure(new Measure("D3.06", 27, 50));
            _man.AddMeasure(new Measure("D3.06", 36, 57));
            _man.AddMeasure(new Measure("D3.06", 21, 39));
        }

        [TestMethod]
        public void GetAllMeasuresTest() {
            int expected = 1;
            int actual = _man.GetMeasures().Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetMeasureByDateTest() {
            DateTime date = DateTime.Today;
            List<Measure> expected = new List<Measure> {
                new Measure("D3.06", 26.4, 46),
                new Measure("D3.06", 27, 50),
                new Measure("D3.06", 36, 57),
                new Measure("D3.06", 21, 39)
            };
            Assert.AreEqual(expected, _man.GetMeasureByDate(date)); //Hvis virker så har den fundet 
        }

        [TestMethod]
        public void AddMeasureTest() {
            Measure toAdd = new Measure("D3.06", 25.2, 46);
            int startLength = _man.GetMeasures().Count();
            _man.AddMeasure(toAdd);
            Assert.AreEqual(startLength + 1, _man.GetMeasures().Count()); //Hvis virker så er bruger blevet tilføjet til listen..
        }

        [TestMethod]
        public void DeleteMeasureTest() {
            int toDelete = 1; //Sletter ID: 1
            int startLength = _man.GetMeasures().Count();
            _man.DeleteMeasure(toDelete);
            Assert.AreEqual(startLength - 1, _man.GetMeasures().Count()); //Hvis virker så er der blevet slettet bruger med ID: 1
        }
    }
}