using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    class ThresholdActivationFunction : IActivationFunction
    {

        /// <summary>
        /// Пороговое значение
        /// </summary>
        public double Threshold { get; set; }

        /// <summary>
        /// Вычисление функции активации
        /// </summary>
        /// <param name="x">Входное значение функции</param>
        /// <returns>Значение активационной функции</returns>
        public double Function(double x)
        {
            if (x > Threshold)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Инициализация пороговой функции
        /// </summary>
        public ThresholdActivationFunction()
        {
            Threshold = 0.5;
        }


        /// <summary>
        /// Инициализация пороговой функции в зависимости от порогового значения
        /// </summary>
        /// <param name="threshold">Пороговое значение</param>
        public ThresholdActivationFunction(double threshold)
        {
            Threshold = threshold;
        }
    }
}
