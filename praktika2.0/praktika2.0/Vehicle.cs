using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace praktika2._0
{
    internal class Vehicle
    {
        private int _id;
        private string _make;
        private string _model;
        private int _year;
        private string _licensePlate;

        public int Id { get => _id; set => _id = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }


        public Vehicle(int id, string make, string model, int year, string licensePlate)
        {
            _id = id;
            _make = make;
            _model = model;
            _year = year;
            _licensePlate = licensePlate;
        }
    }
}
