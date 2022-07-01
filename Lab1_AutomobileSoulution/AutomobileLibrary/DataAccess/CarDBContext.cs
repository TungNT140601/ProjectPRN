using AutomobileLibrary.BussinessObject;
namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        private static List<Car> CarList = new List<Car>()
        {
            new Car{ CarId =1, CarName = "CRV", Manufacturer="Honda",
                Price=30000,ReleaseYear=2021},
            new Car{ CarId =2, CarName = "Ford Forcus", Manufacturer="Ford",
                Price=15000,ReleaseYear=2020}
        };

        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get 
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                } 
            }
        }

        public List<Car> GetCarList => CarList;
        //---------------------------------------------
        public Car GetCarByID(int CarID)
        {
            Car car = CarList.SingleOrDefault(pro => pro.CarId == CarID);
            return car;
        }
        //---------------------------------------------
        //Add new a car
        public void AddNew(Car car)
        {
            Car pro = GetCarByID(car.CarId);
            if(pro == null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("Car is already exists");
            }
        }
        //---------------------------------------------
        //Update a car
        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarId);
            if (c != null)
            {
                var index = CarList.IndexOf(c);
                CarList[index] = car;
            }
            else
            {
                throw new Exception("Car does not already exists.");
            }
        }
        //---------------------------------------------
        //Delete a car
        public void Remove(int CarID)
        {
            Car c = GetCarByID(CarID);
            if (c != null)
            {
                CarList.Remove(c);
            }
            else
            {
                throw new Exception("Car does not already exists.");
            }
        }
    }
}
