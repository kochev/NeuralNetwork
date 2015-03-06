using System;
using System.Diagnostics;

namespace NeuralNetwork
{
    public class Neuron
    {
        /// <summary>
        /// Количество входных параметров
        /// </summary>
        public int InputsCount { get; set; }

        /// <summary>
        /// Выходное значение нейрона
        /// </summary>
        public double Output { get; set; }


        /// <summary>
        /// Веса нейрона
        /// </summary>
        public double[] Weights { get; set; }


        /// <summary>
        /// Инициализация нейрона
        /// </summary>
        /// <param name="inputs">Количество входных параметров</param>
        public Neuron(int inputs)
        {
            InputsCount = inputs;
            Weights = new double[InputsCount];
            Randomize();
        }


        public Neuron()
        {
        }

        /// <summary>
        /// Рандомизация весов нейрона
        /// </summary>
        public void Randomize()
        {
            Random rand = new Random();

            for (int i = 0; i < InputsCount; i++)
            {
                Weights[i] = rand.NextDouble();
            }
        }

        /// <summary>
        /// Вычисляем выходное значение нейрона
        /// </summary>
        /// <param name="inputs">Входные параметры нейрона</param>
        /// <returns>Выходное значение нейрона</returns>
        public double Compute(double[] inputs)
        {
            double sum = 0.0;
            if (inputs.Length != InputsCount)
            {
                throw new Exception("Количество входных параметров задано некорректно!");
            }

            //считаем взвешанную сумму входных значений
            for (int i = 0; i < InputsCount; i++)
            {
                sum += Weights[i] * inputs[i];
            }
            //Debug.Print(sum.ToString());
            //sum += Threshold;

            Output = new ThresholdActivationFunction(0.9).Function(sum);
            return Output;
        }
    }
}
