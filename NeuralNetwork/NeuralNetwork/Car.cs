using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public class Car
    {
        /// <summary>
        /// Модель
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Масса
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Грузоподъемность
        /// </summary>
        public double Capacity { get; set; }

        /// <summary>
        /// Привод
        /// </summary>
        public double Drive { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Длина
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Клиренс
        /// </summary>
        public double Clearance { get; set; }

        /// <summary>
        /// Количество лошадинных сил
        /// </summary>
        public double Power { get; set; }

        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public double Passengers { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int Type { get; set; }



        public Car(string name, double weight, double capacity, double drive, double width, double height, double length, double clearance, double power, double cot, int type)
        {
            Name = name;
            Weight = weight;
            Capacity = capacity;
            Drive = drive;
            Width = width;
            Height = height;
            Length = length;
            Clearance = clearance;
            Power = power;
            Passengers = cot;
            Type = type;
        }


        public Car(string name, double weight, double capacity, double drive, double width, double height, double length, double clearance, double power, double cot)
        {
            Name = name;
            Weight = weight;
            Capacity = capacity;
            Drive = drive;
            Width = width;
            Height = height;
            Length = length;
            Clearance = clearance;
            Power = power;
            Passengers = cot;
            Type = -1;
        }

        public Car()
        {
        }

    }
}
