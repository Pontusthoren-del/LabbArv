using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbArv
{
    internal class Motorcycle:Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(string brand, string model, int maxspeed, int doors, bool gasoline,bool hassidecar) : base(brand, model, maxspeed, doors, gasoline)
        {
            HasSideCar = hassidecar;
        }

    }
}
