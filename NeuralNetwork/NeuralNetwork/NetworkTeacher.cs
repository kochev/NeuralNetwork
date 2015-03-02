using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    class NetworkTeacher
    {
        /// <summary>
        /// Обучаемая сеть
        /// </summary>
        private Network _network;


        /// <summary>
        /// Скорость обучения
        /// </summary>
        public double SpeedOfLearning { get; set; }


        /// <summary>
        /// Инициализация учителя сети
        /// </summary>
        /// <param name="network">Обучаемая сеть</param>
        /// <param name="speedOfLearning">Скорость обучения сети</param>
        public NetworkTeacher(Network network, double speedOfLearning)
        {
            _network = network;
            SpeedOfLearning = speedOfLearning;
        }


        /// <summary>
        /// Обучение сети
        /// </summary>
        /// <param name="inputs">Входные параметры</param>
        /// <param name="outputs">Желаемые выходные парамеры</param>
        /// <returns>Абсолютную погрешность - разность между реальным выходом сети и желаемым выходом</returns>
        public double Teach(double[] inputs, double outputs)
        {
            //разность между реальным сети выходом и желаемым выходом
            double error = 0.0;

            Layer layer = _network.Layers[0];

            // посчитанный сетью выход
            double[] networkOutput = _network.Compute(inputs);

            return error;
        }
    }
}
