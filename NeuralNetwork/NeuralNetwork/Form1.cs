using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class Form1 : Form
    {


        private List<Car> Cars;

        private XmlWorker _xmlWorker = new XmlWorker();

        private Network _network;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var weight = Convert.ToDouble(WeightTextBox.Text);
                var capacity = Convert.ToDouble(CapacityTextBox.Text);
                var drive = Convert.ToDouble(DriveComboBox.SelectedIndex + 1.0);
                var width = Convert.ToDouble(WidthTextBox.Text);
                var height = Convert.ToDouble(HeightTextBox.Text);
                var length = Convert.ToDouble(LengthTextBox.Text);
                var clearance = Convert.ToDouble(ClearanceTextBox.Text);
                var cop = Convert.ToDouble(PassCountTextBox.Text);
                var model = CarNametextBox.Text;
                var power = Convert.ToDouble(PowerTextBox.Text);
                var type = TypeAutoComboBox.SelectedIndex;
                Car car = new Car(model, weight, capacity, drive, width, height, length, clearance, power, cop, type);
                Cars.Add(car);
                CarTable.DataSource = null;
                CarTable.DataSource = Cars;
                //_xmlWorker.Serialize(Cars, "CarsForStudy.xml", typeof(List<Car>));
            }
            catch (Exception exception)
            {
                Debug.Print(exception.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadButton_Click(null, null);
            _network = new Network(1, 9, 3);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _xmlWorker.Serialize(Cars, "CarsForStudy.xml", typeof(List<Car>));
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Cars = (List<Car>)_xmlWorker.Deserialize("CarsForStudy.xml", typeof(List<Car>));
            CarTable.DataSource = null;
            CarTable.DataSource = Cars;
            foreach (var car in Cars)
            {

                checkedListBox1.Items.Add(car.ToString());
            }
        }

        private void CarNametextBox_Enter(object sender, EventArgs e)
        {
            CarNametextBox.Clear();
        }

        private void WeightTextBox_Enter(object sender, EventArgs e)
        {
            WeightTextBox.Clear();
        }

        private void CapacityTextBox_Enter(object sender, EventArgs e)
        {
            CapacityTextBox.Clear();
        }

        private void DriveComboBox_Enter(object sender, EventArgs e)
        {
            DriveComboBox.SelectedIndex = -1;
        }

        private void WidthTextBox_Enter(object sender, EventArgs e)
        {
            WidthTextBox.Clear();
        }

        private void LengthTextBox_Enter(object sender, EventArgs e)
        {
            LengthTextBox.Clear();
        }

        private void HeightTextBox_Enter(object sender, EventArgs e)
        {
            HeightTextBox.Clear();
        }

        private void ClearanceTextBox_Enter(object sender, EventArgs e)
        {
            ClearanceTextBox.Clear();
        }

        private void PowerTextBox_Enter(object sender, EventArgs e)
        {
            PowerTextBox.Clear();
        }

        private void PassCountTextBox_Enter(object sender, EventArgs e)
        {
            PassCountTextBox.Clear();
        }

        private void TypeAutoComboBox_Enter(object sender, EventArgs e)
        {
            TypeAutoComboBox.SelectedIndex = -1;
        }

        private void NotNormalize_CheckedChanged(object sender, EventArgs e)
        {
            if (NotNormalize.Checked)
            {
                LoadButton_Click(null, null);
                Normalize.Checked = false;
            }
        }

        private void Normalize_CheckedChanged(object sender, EventArgs e)
        {
            if (Normalize.Checked)
            {
                NotNormalize.Checked = false;
                DataNormalizer dt = new DataNormalizer(Cars);
                Cars = dt.Normalize();
                CarTable.DataSource = null;
                CarTable.DataSource = Cars;
            }
        }

        private void TeachButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear(); ;
            NetworkTeacher networkTeacher = new NetworkTeacher(_network, 0.000001);

            //for (int i = 0; i < 50000; i++)
            double err = networkTeacher.Teach(Cars);
            while (err > 1.0)
            {
                err = networkTeacher.Teach(Cars);

            }

            listBox1.Items.Add("Error: " + err);
            for (int i = 0; i < _network.Layers[0].NeuronsCount; i++)
            {
                //Debug.Print(_network.Layers[0].Neurons[i].Output.ToString());
                listBox2.Items.Add(_network.Layers[0].Neurons[i].Output);
                //for (int j = 0; j < _network.Layers[0].Neurons[i].Weights.Length; j++)
                //{
                //    listBox2.Items.Add("Neuron " + i.ToString() + " weight: " + _network.Layers[0].Neurons[i].Weights[j]);
                //}
            }
        }

        private void GetClassButton_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var index in checkedListBox1.CheckedIndices)
            {
                //MessageBox.Show(index.ToString());
                var car = Cars.ElementAt((int)index);
                double[] inputs = new double[9] { car.Weight, car.Capacity, car.Drive, car.Width, car.Length, car.Height, car.Clearance, car.Power, car.Passengers };
                var result = string.Join(", ", _network.Compute(inputs));
                listBox2.Items.Add(car.Name + ":" + result);
            }
        }



    }
}
