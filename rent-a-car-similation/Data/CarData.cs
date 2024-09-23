using rent_a_car_similation.Models;

namespace rent_a_car_similation.Data
{
    public class CarData
    {
        private static List<Car> _cars = new List<Car>();

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public Car? GetCarById(int id)
        {
            return _cars.FirstOrDefault(c => c.Id == id);
        }

        public void UpdateCar(Car car)
        {
            var existingCar = GetCarById(car.Id);
            if (existingCar != null)
            {

                existingCar.BrandName = car.BrandName;
                existingCar.ModelName = car.ModelName;
                existingCar.KiloMeter = car.KiloMeter;
                existingCar.DailyPrice = car.DailyPrice;
            }
        }

        public void DeleteCar(int id)
        {
            var car = GetCarById(id);
            if (car != null)
            {
                _cars.Remove(car);
            }
        }
    }
}