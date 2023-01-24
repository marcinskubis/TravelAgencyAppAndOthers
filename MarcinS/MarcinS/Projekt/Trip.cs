using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinS.Projekt
{
    public class Trip
    {
        public List<Trip> list = new List<Trip>();
        public object TripID { get; set; }
        public object Wylot { get; set; }
        public object Przylot { get; set; }
        public object Cena { get; set; }
        public object Dni { get; set; }
        public object Hotel { get; set; }
        public object Data { get; set; }
        
    }
}
