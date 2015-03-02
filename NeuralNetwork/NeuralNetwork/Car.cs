namespace NeuralNetwork
{
    public class Car
    {
        /// <summary>
        /// Модель
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Масса
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Грузоподъемность
        /// </summary>
        public double Capacity { get; set; }

        /// <summary>
        /// Привод
        /// </summary>
        public double Drive { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Длина
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Клиренс
        /// </summary>
        public double Clearance { get; set; }

        /// <summary>
        /// Количество лошадинных сил
        /// </summary>
        public double Power { get; set; }

        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public double Passengers { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public int Type { get; set; }


        /// <summary>
        /// Инициализация авто
        /// </summary>
        /// <param name="name">Марка</param>
        /// <param name="weight">Вес</param>
        /// <param name="capacity">Грузоподъемность</param>
        /// <param name="drive">Привод</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="length">Длина</param>
        /// <param name="clearance">Клиренс</param>
        /// <param name="power">Мощность</param>
        /// <param name="cot">Пассажиры</param>
        /// <param name="type">Тип</param>
        public Car(string name, double weight, double capacity, double drive, double width, double height, double length, double clearance, double power, double cot, int type)
        {
            Name = name;
            Weight = weight;
            Capacity = capacity;
            Drive = drive;
            Width = width;
            Height = height;
            Length = length;
            Clearance = clearance;
            Power = power;
            Passengers = cot;
            Type = type;
        }

        /// <summary>
        /// Инициализация авто
        /// </summary>
        /// <param name="name">Марка</param>
        /// <param name="weight">Вес</param>
        /// <param name="capacity">Грузоподъемность</param>
        /// <param name="drive">Привод</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="length">Длина</param>
        /// <param name="clearance">Клиренс</param>
        /// <param name="power">Мощность</param>
        /// <param name="cot">Пассажиры</param>
        public Car(string name, double weight, double capacity, double drive, double width, double height, double length, double clearance, double power, double cot)
        {
            Name = name;
            Weight = weight;
            Capacity = capacity;
            Drive = drive;
            Width = width;
            Height = height;
            Length = length;
            Clearance = clearance;
            Power = power;
            Passengers = cot;
            Type = -1;
        }

        public Car()
        {
        }

    }
}
