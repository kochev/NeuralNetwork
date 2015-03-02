using System.Collections.Generic;
using System.Linq;

namespace NeuralNetwork
{
    class DataNormalizer
    {
        /// <summary>
        /// Список авто
        /// </summary>
        private List<Car> Cars { get; set; }

        /// <summary>
        /// Инициализация нормализатора
        /// </summary>
        /// <param name="cars">Список авто</param>
        public DataNormalizer(List<Car> cars)
        {
            Cars = cars;
        }

        /// <summary>
        /// Нормализация всех значений для всех авто
        /// </summary>
        /// <returns>Нормализованный список авто</returns>
        public List<Car> Normalize()
        {
            double maxWeight = Cars.Max(obj => obj.Weight);
            double maxCapacity = Cars.Max(obj => obj.Capacity);
            double maxClearance = Cars.Max(obj => obj.Clearance);
            double maxDrive = Cars.Max(obj => obj.Drive);
            double maxWidth = Cars.Max(obj => obj.Width);
            double maxHeight = Cars.Max(obj => obj.Height);
            double maxLength = Cars.Max(obj => obj.Length);
            double maxCountOfPassengers = Cars.Max(obj => obj.Passengers);
            double maxPower = Cars.Max(obj => obj.Power);

            foreach (var car in Cars)
            {
                car.Weight = car.Weight / maxWeight;
                car.Capacity = car.Capacity / maxCapacity;
                car.Clearance = car.Clearance / maxClearance;
                car.Drive = car.Drive / maxDrive;
                car.Width = car.Width / maxWidth;
                car.Height = car.Height / maxHeight;
                car.Length = car.Length / maxLength;
                car.Passengers = car.Passengers / maxCountOfPassengers;
                car.Power = car.Power / maxPower;
            }
            return Cars;
        }
    }
}
