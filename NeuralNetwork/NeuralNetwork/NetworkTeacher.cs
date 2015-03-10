using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// <returns>Абсолютная погрешность - разность между реальным выходом сети и желаемым выходом</returns>
        private double Teach(double[] inputs, double[] outputs)
        {
            //суммарная ошибка при обучении
            double error = 0.0;

            Layer layer = _network.Layers[0];

            //посчитанный сетью выход
            double[] networkOutput = _network.Compute(inputs);

            for (int i = 0; i < layer.NeuronsCount; i++)
            {
                //разность между реальным выходом сети и желаемым выходом
                double err = outputs[i] - networkOutput[i];

                if (Math.Abs(err) > 0.000000001)
                {
                    //возьмем нейрон который дал нехороший ответ
                    Neuron neuron = layer.Neurons[i];

                    //пересчитаем его веса
                    for (int j = 0; j < neuron.InputsCount; j++)
                    {
                        neuron.Weights[j] += inputs[j] * err * SpeedOfLearning;
                    }


                    //учитываем ошибку(по модулю)
                    error += Math.Abs(err);
                }
            }
            return error;
        }


        /// <summary>
        /// Обучение на множестве примеров
        /// </summary>
        /// <param name="cars">Авто для обучения сети</param>
        /// <returns>Суммарная ошибка при обучении</returns>
        public double Teach(List<Car> cars)
        {
            //List<Car> cars = new DataNormalizer(c).Normalize();
            double error = 0.0;
            foreach (var car in cars)
            {
                double[] outputs = new double[_network.Layers[0].NeuronsCount];
                double[] inputs = new double[9] { car.Weight, car.Capacity, car.Drive, car.Width, car.Length, car.Height, car.Clearance, car.Power, car.Passengers };

                switch (car.Type)
                {
                    case 0:
                        outputs = new[] { 1d, 0d, 0d, 0d };
                        break;
                    case 1:
                        outputs = new[] { 0d, 1d, 0d, 0d };
                        break;
                    case 2:
                        outputs = new[] { 0d, 0d, 1d, 0d };
                        break;
                    case 3:
                        outputs = new[] { 0d, 0d, 0d, 1d };
                        break;

                }

                error += Teach(inputs, outputs);
            }
            return error;
        }
    }



}
