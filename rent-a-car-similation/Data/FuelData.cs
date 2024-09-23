using rent_a_car_similation.Models;

namespace rent_a_car_similation.Data
{
    public class FuelData
    {
        private List<Fuel> _fuels = new();

        public List<Fuel> GetAllFuels() => _fuels;

        public Fuel? GetFuelById(int id) => _fuels.FirstOrDefault(f => f.Id == id);

        public void AddFuel(Fuel fuel) => _fuels.Add(fuel);

        public void UpdateFuel(Fuel fuel)
        {
            var existingFuel = GetFuelById(fuel.Id);
            if (existingFuel != null)
            {
                Console.WriteLine("Yakıt güncellendi");
            }
        }

        public void DeleteFuel(int id) => _fuels.RemoveAll(f => f.Id == id);
    }
}
