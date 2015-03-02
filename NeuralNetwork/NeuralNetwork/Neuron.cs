using System;

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
        /// Пороговое значение
        /// </summary>
        public double Threshold { get; set; }


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

        /// <summary>
        /// Рандомизация весов нейрона
        /// </summary>
        public void Randomize()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < InputsCount; i++)
            {
                Weights[i] = rand.NextDouble();
            }
            Threshold = rand.NextDouble();
        }

        /// <summary>
        /// Вычисляем выходное значение нейрона
        /// </summary>
        /// <param name="input">Входные параметры нейрона</param>
        /// <returns></returns>
        public double Compute(double[] input)
        {
            double sum = 0.0;
            if (input.Length != InputsCount)
            {
                throw new Exception("Количество входных параметров задано некорректно!");
            }

            // считаем взвешанную сумму входных значений
            for (int i = 0; i < InputsCount; i++)
            {
                sum += Weights[i] * input[i];
            }
            sum += Threshold;

            //TODO: Outputs: посчитать с помощью функции активации?
            return Output;
        }
    }
}
