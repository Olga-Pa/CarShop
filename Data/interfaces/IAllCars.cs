using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    public interface IAllCars
    {

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get;  set; }
        Car getObjectCar(int carId);

    }
}