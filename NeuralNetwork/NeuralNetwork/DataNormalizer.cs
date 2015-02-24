using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    class DataNormalizer
    {
        private List<Car> Cars { get; set; }


        public DataNormalizer(List<Car> cars)
        {
            Cars = cars;
        }

        public List<Car> Normalize()
        {
            float maxWeight = Cars.Max(obj => obj.Weight);
            float maxCapacity = Cars.Max(obj => obj.Capacity);
            float maxClearance = Cars.Max(obj => obj.Clearance);
            float maxDrive = Cars.Max(obj => obj.Drive);
            float maxWidth = Cars.Max(obj => obj.Width);
            float maxHeight = Cars.Max(obj => obj.Height);
            float maxLength = Cars.Max(obj => obj.Length);
            float maxCountOfPassengers = Cars.Max(obj => obj.CountOfPassengers);
            float maxPower = Cars.Max(obj => obj.Power);

            foreach (var car in Cars)
            {
                car.Weight = car.Weight / maxWeight;
                car.Capacity = car.Capacity / maxCapacity;
                car.Clearance = car.Clearance / maxClearance;
                car.Drive = car.Drive / maxDrive;
                car.Width = car.Width / maxWidth;
                car.Height = car.Height / maxHeight;
                car.Length = car.Length / maxLength;
                car.CountOfPassengers = car.CountOfPassengers / maxCountOfPassengers;
                car.Power = car.Power / maxPower;
            }
            return Cars;
        }
    }
}
