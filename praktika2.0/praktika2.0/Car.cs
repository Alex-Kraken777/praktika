using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace praktika2._0
{
    internal class Car : Vehicle
    {
        private int _numSeats;
        private string _bodyType;

        public int NumSeats { get => _numSeats; set => _numSeats = value; }
        public string BodyType { get => _bodyType; set => _bodyType = value; }

        public Car(int id, string make, string model, int year, string licensePlate, int numSeats, string bodyType) 
            : base(id, make, model, year, licensePlate)
        {
            _numSeats = numSeats;
            _bodyType = bodyType;
        }
    }
}
