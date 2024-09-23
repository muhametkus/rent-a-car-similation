using rent_a_car_similation.Data;
using rent_a_car_similation.Models;

namespace rent_a_car_similation.Services
{
    public class ColorService
    {
        private readonly ColorData _colorData;

        public ColorService(ColorData colorData)
        {
            _colorData = colorData;
        }

        public List<Color> GetAllColors()
        {
            return _colorData.GetAllColors();
        }

        public Color? GetColorById(int id)
        {
            return _colorData.GetColorById(id);
        }

        public void AddColor(Color color)
        {
            _colorData.AddColor(color);
        }

        public void UpdateColor(Color color)
        {
            var existingColor = _colorData.GetColorById(color.Id);
            if (existingColor != null)
            {
                existingColor.Name = color.Name;
                _colorData.UpdateColor(existingColor);
            }
        }

        public void DeleteColor(int id)
        {
            _colorData.DeleteColor(id);
        }
    }
}
