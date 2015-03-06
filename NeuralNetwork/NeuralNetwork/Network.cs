using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NeuralNetwork
{
    [XmlInclude(typeof (Network))]
    [Serializable]
    public class Network
    {
        /// <summary>
        /// Количество входных параметров для сети
        /// </summary>
        public int InputsCount { get; set; }


        /// <summary>
        /// Выходной вектор сети
        /// </summary>
        public double[] Outputs { get; set; }


        /// <summary>
        /// Количество слоев в сети
        /// </summary>
        public int LayersCount { get; set; }


        /// <summary>
        /// Слои нейронной сети
        /// </summary>
        public Layer[] Layers { get; set; }

        /// <summary>
        /// Инициализация сети
        /// </summary>
        /// <param name="layers">Количество слоев сети</param>
        /// <param name="inputs">Количество входных параметров для нейрона</param>
        /// <param name="neurons">Количество нейронов в слое</param>
        public Network(int layers, int inputs, int neurons)
        {
            InputsCount = inputs;
            LayersCount = layers;

            Layers = new Layer[LayersCount];

            //создадим слои
            for (int i = 0; i < LayersCount; i++)
            {
                Layers[i] = new Layer(neurons, InputsCount);
            }
        }

        public Network()
        {
        }



        /// <summary>
        /// Рандомизация всех нейронов для всех слоев
        /// </summary>
        public void RandomizeLayers()
        {
            foreach (var layer in Layers)
            {
                layer.RandomizeNeurons();
            }
        }


        /// <summary>
        /// Расчет выходного вектора сети
        /// </summary>
        /// <param name="input">Входные параметры для каждого нейрона каждого слоя</param>
        /// <returns>Выходной вектор сети</returns>
        public virtual double[] Compute(double[] input)
        {
            //считаем каждый нейрон каждого слоя
            foreach (var layer in Layers)
            {
                Outputs = layer.Compute(input);
                //Debug.Print(Outputs[0] + "-" + Outputs[1] + "-" + Outputs[2] + "-" + Outputs[3]);
            }

            return Outputs;
        }


        /// <summary>
        /// Сохранение сети
        /// </summary>
        public void Save()
        {
            XmlWorker xmlWorker = new XmlWorker();
            xmlWorker.Serialize(this, "NeuralNetwork", typeof(Network));
        }
    }
}
