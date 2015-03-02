namespace NeuralNetwork
{
    class Network
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
