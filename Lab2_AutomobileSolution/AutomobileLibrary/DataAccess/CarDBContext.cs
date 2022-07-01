﻿using System.Data;
using AutomobileLibrary.BussinessObject;
using Microsoft.Data.SqlClient;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext : BaseDAL
    {
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Car> GetCarList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select CarID, CarName, Manufacturer, Price, ReleaseYear from Car";
            var cars = new List<Car>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    cars.Add(new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return cars;
        }
        public Car GetCarByID(int carID)
        {
            Car car = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select CarID, CarName, Manufacturer, ReleaseYear from Car Where CarID = @CarID";
            try
            {
                var param = dataProvider.CreateParameter("@CarID", 4, carID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection,
                    param);
                if (dataReader.Read())
                {
                    car = new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetInt32(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return car;
        }
        public void AddNew(Car car)
        {
            try
            {
                Car pro = GetCarByID(car.CarID);
                if (pro == null)
                {
                    string SQLSelect = "Insert INTO Car (CarID, CarName, Manufacturer, Price, ReleaseYear) Values (@CarID, @CarName, @Manufacturer, @Price, @ReleaseYear)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@ReleaseYear", 4, car.ReleaseYear, DbType.Int32));
                    dataProvider.Insert(SQLSelect, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("This car is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(Car car)
        {
            try
            {
                Car c = GetCarByID(car.CarID);
                if (c != null)
                {
                    string SQLSelect = "Update Car Set CarName=@CarName," +
                        "Manufacturer=@Manufacturer, Price=@Price, ReleaseYear=@ReleaseYear" +
                        "Where CarID=@CarID";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameter.Add(dataProvider.CreateParameter("@ReleaseYear", 4, car.ReleaseYear, DbType.Int32));
                    dataProvider.Update(SQLSelect, CommandType.Text, parameter.ToArray());
                }
                else
                {
                    throw new Exception("The car does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Remove(int carID)
        {
            try
            {
                Car c = GetCarByID(carID);
                if (c != null)
                {
                    string SQLDelete = "Delete Car where CarID=@CarID";
                    var param = dataProvider.CreateParameter("@CarID", 4, carID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The car does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
