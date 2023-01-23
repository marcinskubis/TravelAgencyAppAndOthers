using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinS.Projekt
{
    public class Trip
    {
        public int TripID { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int Length { get; set; }
        public string Hotel { get; set; }
        public DateTime Date { get; set; }
    }
}
