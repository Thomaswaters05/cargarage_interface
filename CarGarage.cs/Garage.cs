using CarGarage.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
 
    public class Garage
    {
        public IStorage ParkingArea { get; set; } //this is a property INTERFACE for the entire project

        public Garage(IStorage carArea)
        {
            this.ParkingArea = carArea;
        }
    }
}
