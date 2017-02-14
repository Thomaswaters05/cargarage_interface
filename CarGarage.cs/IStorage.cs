using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage.cs
{
    public interface IStorage
    {
        List <string> GetCars();
        bool ParkCar(string carName);
        string DriveOut(string carName);

    }
}
