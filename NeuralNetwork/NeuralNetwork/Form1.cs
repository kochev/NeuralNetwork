using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class Form1 : Form
    {


        private List<Car> Cars;

        private XmlWorker _xmlWorker = new XmlWorker();

        private Network _network;

        private int iterations = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cars = (List<Car>)_xmlWorker.Deserialize("CarsForStudy.xml", typeof(List<Car>));
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
            _network = new Network(1, 9, 4);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _xmlWorker.Serialize(Cars, "CarsForStudy.xml", typeof(List<Car>));
            LoadButton_Click(null, null);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            CarsChekedBox.Items.Clear();

            Cars = (List<Car>)_xmlWorker.Deserialize("CarsForStudy.xml", typeof(List<Car>));

            CarTable.DataSource = null;
            CarTable.DataSource = Cars;
            foreach (var car in Cars)
            {
                CarsChekedBox.Items.Add(car.ToString());
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
            try
            {
                GetClassButton.Enabled = false;
                progressBar1.Value = 0;
                backgroundWorker1.RunWorkerAsync(trackBar1.Value);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void GetClassButton_Click(object sender, EventArgs e)
        {
            string[] types = new string[4] { "Легковая", "Грузовая", "Внедорожник", "Спортивная" };
            listBox1.Items.Clear();
            List<Car> normalCars = new DataNormalizer(Cars).Normalize();
            foreach (var index in CarsChekedBox.CheckedIndices)
            {
                var car = normalCars.ElementAt((int)index);
                double[] inputs = new double[9] { car.Weight, car.Capacity, car.Drive, car.Width, car.Length, car.Height, car.Clearance, car.Power, car.Passengers };
                double[] output = _network.Compute(inputs);
                string resultString = car.Name + ":";
                for (int i = 0; i < output.Length; i++)
                {
                    if (output[i] != 0)
                    {
                        resultString += " " + types[i] + "(" + output[i] * 100 + " %)";
                    }
                }
                listBox1.Items.Add(resultString);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            iterations = 0;
            NetworkTeacher networkTeacher = new NetworkTeacher(_network, 0.00001);

            List<Car> carsForTeaching = new List<Car>();
            Cars = new DataNormalizer(Cars).Normalize();
            foreach (var index in CarsChekedBox.CheckedIndices)
            {
                carsForTeaching.Add(Cars[(int)index]);
            }

            //MessageBox.Show("Выбрано " + carsForTeaching.Count + " авто для обучения.");

            double err = networkTeacher.Teach(carsForTeaching);

            double tmp = Convert.ToDouble(e.Argument);
            while (err > tmp)
            {
                err = networkTeacher.Teach(carsForTeaching);
                iterations++;
                //backgroundWorker1.ReportProgress((int)err, "error");
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            GetClassButton.Enabled = true;
            ResultTeachingLabel.Text = "Количество итераций для обучения:  " + iterations;
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage < 10 + trackBar1.Value)//e.ProgressPercentage < (10 + trackBar1.Value) &&
            {
                //label11.Text = ((int)((10 + trackBar1.Value) - Math.Max(trackBar1.Value, e.ProgressPercentage)) * 10).ToString();
                progressBar1.Value = (int)((10 + trackBar1.Value) - Math.Max(trackBar1.Value, e.ProgressPercentage));
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            backgroundWorker1.Dispose();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SumErrorLabel.Text = trackBar1.Value + "%";
        }

        private void SaveNetworkButton_Click(object sender, EventArgs e)
        {
            _xmlWorker.Serialize(_network, "Network.xml", typeof(Network));
        }

        private void LoadNetworkButton_Click(object sender, EventArgs e)
        {
            _network = (Network)_xmlWorker.Deserialize("Network.xml", typeof(Network));
            SaveNetworkButton.Enabled = true;
        }



    }
}
