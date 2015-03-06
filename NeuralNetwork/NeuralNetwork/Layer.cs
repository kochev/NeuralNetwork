namespace NeuralNetwork
{
    public class Layer
    {
        /// <summary>
        /// Количество входных параметров для слоя
        /// </summary>
        public int InputsCount { get; set; }

        /// <summary>
        /// Количество нейронов в слое
        /// </summary>
        public int NeuronsCount { get; set; }

        /// <summary>
        /// Нейроны слоя
        /// </summary>
        public Neuron[] Neurons { get; set; }

        /// <summary>
        /// Выходной вектор слоя
        /// </summary>
        public double[] Outputs { get; set; }

        /// <summary>
        /// Инициализация слоя
        /// </summary>
        /// <param name="neurons">Количество нейронов в слое</param>
        /// <param name="inputs">Количество входных параметров для каждого нейрона</param>
        public Layer(int neurons, int inputs)
        {
            InputsCount = inputs;
            NeuronsCount = neurons;

            Neurons = new Neuron[NeuronsCount];

            for (int i = 0; i < NeuronsCount; i++)
            {
                Neurons[i] = new Neuron(InputsCount);
            }

            Outputs = new double[NeuronsCount];
        }

        public Layer()
        {
        }

        /// <summary>
        /// Рандомизация нейронов слоя
        /// </summary>
        public void RandomizeNeurons()
        {
            foreach (var neuron in Neurons)
            {
                neuron.Randomize();
            }
        }


        /// <summary>
        /// Расчет выходного вектора слоя
        /// </summary>
        /// <param name="input">Входные параметры для каждого нейрона</param>
        /// <returns>Выходной вектор слоя</returns>
        public double[] Compute(double[] input)
        {
            //считаем каждый нейрон слоя
            for (int i = 0; i < NeuronsCount; i++)
            {
                Outputs[i] = Neurons[i].Compute(input);
            }
            return Outputs;
        }

    }
}
