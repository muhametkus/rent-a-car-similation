using rent_a_car_similation.Data;
using rent_a_car_similation.Models;
using rent_a_car_similation.Models.DTO;

namespace rent_a_car_similation.Services
{
    public class CarService
    {
        private readonly CarData _carData;

        public CarService(CarData carData)
        {
            _carData = carData;
        }


        public List<Car> GetAllCars()
        {
            return _carData.GetAllCars();
        }


        public Car? GetCarById(int id)
        {
            return _carData.GetCarById(id);
        }

  
        public void AddCar(Car car)
        {
            _carData.AddCar(car); 
        }


        public void UpdateCar(Car car)
        {
            _carData.UpdateCar(car);
        }

        // Araba silme
        public void DeleteCar(int id)
        {
            _carData.DeleteCar(id);
        }

        public List<Car> GetAllCarDetails()
        {
            return _carData.GetAllCars();
        }

        public List<Car> GetDetailById(int id)
        {
            var car = _carData.GetCarById(id); 
            if (car != null)
            {
                return new List<Car> { car };
            }
            else
            {
                return new List<Car>();
            }
        }
    }
}
