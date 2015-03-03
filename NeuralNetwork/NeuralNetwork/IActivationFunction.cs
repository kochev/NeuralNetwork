using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    interface IActivationFunction
    {
        /// <summary>
        /// Вычисление функции активации
        /// </summary>
        /// <param name="x">Входное значение функции</param>
        /// <returns>Значение активационной функции</returns>
        double Function(double x);


        /// <summary>
        /// Пороговое значение
        /// </summary>
        double Threshold { get; set; }
    }
}
