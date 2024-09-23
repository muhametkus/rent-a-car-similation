using rent_a_car_similation.Models;

namespace rent_a_car_similation.Data
{
    public class ColorData
    {
        private List<Color> _colors = new();

        public List<Color> GetAllColors() => _colors;

        public Color? GetColorById(int id) => _colors.FirstOrDefault(c => c.Id == id);

        public void AddColor(Color color) => _colors.Add(color);

        public void UpdateColor(Color color)
        {
            var existingColor = GetColorById(color.Id);
            if (existingColor != null)
            {
                Console.WriteLine("güncelleme yapıldı");
            }
        }

        public void DeleteColor(int id) => _colors.RemoveAll(c => c.Id == id);
    }
}
