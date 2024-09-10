using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace praktika2._0
{
    internal class Car : Vehicle
    {
        private int _id;
        private string _make;

        public int Id { get => _id; set => _id = value; }
        public string Make { get => _make; set => _make = value; }
        public Car(int id, string make, string model, int year, string licensePlate, int numSeats, string bodyType, double mileage) 
            : base(make, model, year, licensePlate, numSeats, bodyType, mileage)
        {
            _id = id;
            _make = make;
        }

    }
}
