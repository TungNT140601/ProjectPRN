using System.Collections;
using AutomobileLibrary.BussinessObject;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int carID);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int carID);
    }
}
