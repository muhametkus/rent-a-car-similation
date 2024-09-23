using rent_a_car_similation.Data;
using rent_a_car_similation.Models;

namespace rent_a_car_similation.Services
{
    public class TransmissionService
    {
        private readonly TransmissionData _transmissionData;

        public TransmissionService(TransmissionData transmissionData)
        {
            _transmissionData = transmissionData;
        }


        public List<Transmission> GetAllTransmissions()
        {
            return _transmissionData.GetAllTransmissions();
        }

        public Transmission? GetTransmissionById(int id)
        {
            return _transmissionData.GetTransmissionById(id);
        }

        public void AddTransmission(Transmission transmission)
        {
            _transmissionData.AddTransmission(transmission);
        }


        public void UpdateTransmission(Transmission transmission)
        {
            var existingTransmission = _transmissionData.GetTransmissionById(transmission.Id);
            if (existingTransmission != null)
            {
                existingTransmission.Name = transmission.Name;
                _transmissionData.UpdateTransmission(existingTransmission);
            }
        }

        public void DeleteTransmission(int id)
        {
            _transmissionData.DeleteTransmission(id);
        }
    }
}
