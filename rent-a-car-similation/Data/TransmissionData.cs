using rent_a_car_similation.Models;

namespace rent_a_car_similation.Data
{
    public class TransmissionData
    {
        private List<Transmission> _transmissions = new();

        public List<Transmission> GetAllTransmissions() => _transmissions;

        public Transmission? GetTransmissionById(int id) => _transmissions.FirstOrDefault(t => t.Id == id);

        public void AddTransmission(Transmission transmission) => _transmissions.Add(transmission);

        public void UpdateTransmission(Transmission transmission)
        {
            var existingTransmission = GetTransmissionById(transmission.Id);
            if (existingTransmission != null)
            {
                Console.WriteLine("vites güncellendi");
            }
        }

        public void DeleteTransmission(int id) => _transmissions.RemoveAll(t => t.Id == id);
    }
}
