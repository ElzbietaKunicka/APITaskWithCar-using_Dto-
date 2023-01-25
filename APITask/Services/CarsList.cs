using System.Xml.Linq;

namespace APITask.Services
{
    public class CarsList : ICarsList
    {
        private int _lastId;
        private List<Car> _cars = new List<Car>();
        public void AddNewCarToList(CarDto carDto)
        {
            _lastId++;
            _cars.Add(new Car
            {
                Id = _lastId,
                Color = carDto.Color,
                Brand = carDto.Brand,
            });
        }

        public void DeleteCarById(int id)
        {
            var carToDelete = _cars.FirstOrDefault(i => i.Id == id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetALLCars()
        {
            return _cars;
        }

        public List<Car> GetCarsByColor(string color)
        {
            return _cars.FindAll(i => i.Color == color);
            
        }

        public void UpdateCarById(int id, string color, string brand)
        {
            var existingCar = _cars.FirstOrDefault(i => i.Id == id);
            existingCar.Color = color;
            existingCar.Brand = brand;
        }
    }
}
