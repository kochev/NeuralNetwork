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

                if (err > -0.05 && err < 0.05)
                {
                    //возьмем нейрон который дал нехороший ответ
                    Neuron neuron = layer.Neurons[i];

                    //пересчитаем его веса
                    for (int j = 0; j < neuron.InputsCount; j++)
                    {
                        neuron.Weights[j] = neuron.Weights[j] + inputs[j] * err * SpeedOfLearning;
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
            double error = 0.0;
            double[][] inputs;
            double[][] outpus;
            foreach (var car in cars)
            {

            }

            //TODO: для всех авто обучить в вышеописанном методе
            return error;
        }
    }



}
