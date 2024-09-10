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
        private string _model;
        private int _year;
        private string _licensePlate;
        private int _numSeats;
        private string _bodyType;
        private double _mileage; 

        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        public int NumSeats { get => _numSeats; set => _numSeats = value; }
        public string BodyType { get => _bodyType; set => _bodyType = value; }
        public double Mileage { get => _mileage; set => _mileage = value; }

        public Vehicle(string model, string v, int year, string licensePlate, int numSeats, string bodyType, double mileage)
        {
            _model = model;
            _year = year;
            _licensePlate = licensePlate;
            _numSeats = numSeats;
            _bodyType = bodyType;
            _mileage = mileage; 
        }
        public double GetMileage()
        {
            return _mileage;
        }

        public void SetMileage(double mileage)
        {
            _mileage = mileage;
        }

    }
}
