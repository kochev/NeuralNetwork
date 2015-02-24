using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    class Car
    {
        /// <summary>
        /// Масса
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Грузоподъемность
        /// </summary>
        public float Capacity { get; set; }

        /// <summary>
        /// Привод
        /// </summary>
        public float Drive { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        public float Width { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// Длина
        /// </summary>
        public float Length { get; set; }

        /// <summary>
        /// Клиренс
        /// </summary>
        public float Clearance { get; set; }

        /// <summary>
        /// Количество лошадинных сил
        /// </summary>
        public float Power { get; set; }

        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public float CountOfPassengers { get; set; }
    }
}
