using rent_a_car_similation.Data;
using rent_a_car_similation.Models;

namespace rent_a_car_similation.Services
{
    public class FuelService
    {
        private readonly FuelData _fuelData;

        public FuelService(FuelData fuelData)
        {
            _fuelData = fuelData;
        }

        public List<Fuel> GetAllFuels()
        {
            return _fuelData.GetAllFuels();
        }


        public Fuel? GetFuelById(int id)
        {
            return _fuelData.GetFuelById(id);
        }

        public void AddFuel(Fuel fuel)
        {
            _fuelData.AddFuel(fuel);
        }

        public void UpdateFuel(Fuel fuel)
        {
            var existingFuel = _fuelData.GetFuelById(fuel.Id);
            if (existingFuel != null)
            {
                existingFuel.Name = fuel.Name;
                _fuelData.UpdateFuel(existingFuel);
            }
        }

        public void DeleteFuel(int id)
        {
            _fuelData.DeleteFuel(id);
        }
    }
}
