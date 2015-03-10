namespace NeuralNetwork
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CarTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Normalize = new System.Windows.Forms.CheckBox();
            this.NotNormalize = new System.Windows.Forms.CheckBox();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TypeAutoComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PassCountTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearanceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.DriveComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarNametextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SumErrorLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ResultTeachingLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoadNetworkButton = new System.Windows.Forms.Button();
            this.SaveNetworkButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GetClassButton = new System.Windows.Forms.Button();
            this.CarsChekedBox = new System.Windows.Forms.CheckedListBox();
            this.TeachButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1092, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.CarTable);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.LoadButton);
            this.tabPage1.Controls.Add(this.SaveButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1084, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Стартовые параметры";
            // 
            // CarTable
            // 
            this.CarTable.AllowUserToAddRows = false;
            this.CarTable.AllowUserToDeleteRows = false;
            this.CarTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.CarTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.CarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarTable.GridColor = System.Drawing.SystemColors.Control;
            this.CarTable.Location = new System.Drawing.Point(337, 22);
            this.CarTable.Name = "CarTable";
            this.CarTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CarTable.Size = new System.Drawing.Size(734, 600);
            this.CarTable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Normalize);
            this.panel1.Controls.Add(this.NotNormalize);
            this.panel1.Controls.Add(this.AddCarButton);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TypeAutoComboBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.PassCountTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.PowerTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ClearanceTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.HeightTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LengthTextBox);
            this.panel1.Controls.Add(this.DriveComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.WidthTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CapacityTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.WeightTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CarNametextBox);
            this.panel1.Location = new System.Drawing.Point(17, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 601);
            this.panel1.TabIndex = 0;
            // 
            // Normalize
            // 
            this.Normalize.AutoSize = true;
            this.Normalize.Location = new System.Drawing.Point(14, 571);
            this.Normalize.Name = "Normalize";
            this.Normalize.Size = new System.Drawing.Size(163, 17);
            this.Normalize.TabIndex = 25;
            this.Normalize.Text = "Нормализованные данные";
            this.Normalize.UseVisualStyleBackColor = true;
            this.Normalize.CheckedChanged += new System.EventHandler(this.Normalize_CheckedChanged);
            // 
            // NotNormalize
            // 
            this.NotNormalize.AutoSize = true;
            this.NotNormalize.Checked = true;
            this.NotNormalize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NotNormalize.Location = new System.Drawing.Point(14, 541);
            this.NotNormalize.Name = "NotNormalize";
            this.NotNormalize.Size = new System.Drawing.Size(165, 17);
            this.NotNormalize.TabIndex = 24;
            this.NotNormalize.Text = "Данные в \"понятном\" виде";
            this.NotNormalize.UseVisualStyleBackColor = true;
            this.NotNormalize.CheckedChanged += new System.EventHandler(this.NotNormalize_CheckedChanged);
            // 
            // AddCarButton
            // 
            this.AddCarButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarButton.Location = new System.Drawing.Point(14, 499);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(273, 23);
            this.AddCarButton.TabIndex = 21;
            this.AddCarButton.Text = "Добавить авто";
            this.AddCarButton.UseVisualStyleBackColor = false;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Тип автомобиля";
            // 
            // TypeAutoComboBox
            // 
            this.TypeAutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeAutoComboBox.FormattingEnabled = true;
            this.TypeAutoComboBox.Items.AddRange(new object[] {
            "Легковое авто",
            "Грузовое авто",
            "Внедорожник",
            "Спортивное авто"});
            this.TypeAutoComboBox.Location = new System.Drawing.Point(14, 460);
            this.TypeAutoComboBox.Name = "TypeAutoComboBox";
            this.TypeAutoComboBox.Size = new System.Drawing.Size(273, 21);
            this.TypeAutoComboBox.TabIndex = 19;
            this.TypeAutoComboBox.Enter += new System.EventHandler(this.TypeAutoComboBox_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Количество пассажиров";
            // 
            // PassCountTextBox
            // 
            this.PassCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassCountTextBox.Location = new System.Drawing.Point(14, 412);
            this.PassCountTextBox.Name = "PassCountTextBox";
            this.PassCountTextBox.Size = new System.Drawing.Size(273, 20);
            this.PassCountTextBox.TabIndex = 17;
            this.PassCountTextBox.Tag = "";
            this.PassCountTextBox.Enter += new System.EventHandler(this.PassCountTextBox_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Количество л.с.";
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PowerTextBox.Location = new System.Drawing.Point(14, 368);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.Size = new System.Drawing.Size(273, 20);
            this.PowerTextBox.TabIndex = 15;
            this.PowerTextBox.Tag = "";
            this.PowerTextBox.Enter += new System.EventHandler(this.PowerTextBox_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Клиренс";
            // 
            // ClearanceTextBox
            // 
            this.ClearanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClearanceTextBox.Location = new System.Drawing.Point(14, 325);
            this.ClearanceTextBox.Name = "ClearanceTextBox";
            this.ClearanceTextBox.Size = new System.Drawing.Size(273, 20);
            this.ClearanceTextBox.TabIndex = 13;
            this.ClearanceTextBox.Tag = "";
            this.ClearanceTextBox.Enter += new System.EventHandler(this.ClearanceTextBox_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Высота";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightTextBox.Location = new System.Drawing.Point(14, 282);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(273, 20);
            this.HeightTextBox.TabIndex = 11;
            this.HeightTextBox.Tag = "";
            this.HeightTextBox.Enter += new System.EventHandler(this.HeightTextBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Длина";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LengthTextBox.Location = new System.Drawing.Point(14, 240);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(273, 20);
            this.LengthTextBox.TabIndex = 9;
            this.LengthTextBox.Tag = "";
            this.LengthTextBox.Enter += new System.EventHandler(this.LengthTextBox_Enter);
            // 
            // DriveComboBox
            // 
            this.DriveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriveComboBox.FormattingEnabled = true;
            this.DriveComboBox.Items.AddRange(new object[] {
            "Задний привод",
            "Передний привод",
            "Полный привод"});
            this.DriveComboBox.Location = new System.Drawing.Point(14, 152);
            this.DriveComboBox.Name = "DriveComboBox";
            this.DriveComboBox.Size = new System.Drawing.Size(273, 21);
            this.DriveComboBox.TabIndex = 6;
            this.DriveComboBox.Enter += new System.EventHandler(this.DriveComboBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ширина";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidthTextBox.Location = new System.Drawing.Point(14, 196);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(273, 20);
            this.WidthTextBox.TabIndex = 8;
            this.WidthTextBox.Tag = "";
            this.WidthTextBox.Enter += new System.EventHandler(this.WidthTextBox_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Грузоподъемность";
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CapacityTextBox.Location = new System.Drawing.Point(14, 111);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(273, 20);
            this.CapacityTextBox.TabIndex = 4;
            this.CapacityTextBox.Tag = "";
            this.CapacityTextBox.Enter += new System.EventHandler(this.CapacityTextBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Масса";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightTextBox.Location = new System.Drawing.Point(14, 67);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(273, 20);
            this.WeightTextBox.TabIndex = 2;
            this.WeightTextBox.Tag = "";
            this.WeightTextBox.Enter += new System.EventHandler(this.WeightTextBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Модель";
            // 
            // CarNametextBox
            // 
            this.CarNametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarNametextBox.Location = new System.Drawing.Point(14, 25);
            this.CarNametextBox.Name = "CarNametextBox";
            this.CarNametextBox.Size = new System.Drawing.Size(273, 20);
            this.CarNametextBox.TabIndex = 0;
            this.CarNametextBox.Tag = "";
            this.CarNametextBox.Enter += new System.EventHandler(this.CarNametextBox_Enter);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(151, 646);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(128, 35);
            this.LoadButton.TabIndex = 23;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(17, 646);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(128, 35);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Cохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.SumErrorLabel);
            this.tabPage2.Controls.Add(this.ErrorLabel);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.ResultTeachingLabel);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.TeachButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1084, 700);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа с сетью";
            // 
            // SumErrorLabel
            // 
            this.SumErrorLabel.AutoSize = true;
            this.SumErrorLabel.Location = new System.Drawing.Point(380, 91);
            this.SumErrorLabel.Name = "SumErrorLabel";
            this.SumErrorLabel.Size = new System.Drawing.Size(21, 13);
            this.SumErrorLabel.TabIndex = 8;
            this.SumErrorLabel.Text = "5%";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(20, 91);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(198, 13);
            this.ErrorLabel.TabIndex = 7;
            this.ErrorLabel.Text = "Возможная суммарная погрешность ";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(224, 91);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(144, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(208, 17);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(851, 46);
            this.progressBar1.TabIndex = 5;
            // 
            // ResultTeachingLabel
            // 
            this.ResultTeachingLabel.AutoSize = true;
            this.ResultTeachingLabel.Location = new System.Drawing.Point(707, 91);
            this.ResultTeachingLabel.Name = "ResultTeachingLabel";
            this.ResultTeachingLabel.Size = new System.Drawing.Size(195, 13);
            this.ResultTeachingLabel.TabIndex = 4;
            this.ResultTeachingLabel.Text = "Количество итераций для обучения:  ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LoadNetworkButton);
            this.panel2.Controls.Add(this.SaveNetworkButton);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.GetClassButton);
            this.panel2.Controls.Add(this.CarsChekedBox);
            this.panel2.Location = new System.Drawing.Point(20, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 540);
            this.panel2.TabIndex = 3;
            // 
            // LoadNetworkButton
            // 
            this.LoadNetworkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadNetworkButton.Location = new System.Drawing.Point(749, 457);
            this.LoadNetworkButton.Name = "LoadNetworkButton";
            this.LoadNetworkButton.Size = new System.Drawing.Size(271, 47);
            this.LoadNetworkButton.TabIndex = 4;
            this.LoadNetworkButton.Text = "Загрузить сеть";
            this.LoadNetworkButton.UseVisualStyleBackColor = true;
            this.LoadNetworkButton.Click += new System.EventHandler(this.LoadNetworkButton_Click);
            // 
            // SaveNetworkButton
            // 
            this.SaveNetworkButton.Location = new System.Drawing.Point(417, 457);
            this.SaveNetworkButton.Name = "SaveNetworkButton";
            this.SaveNetworkButton.Size = new System.Drawing.Size(271, 47);
            this.SaveNetworkButton.TabIndex = 3;
            this.SaveNetworkButton.Text = "Сохранить сеть";
            this.SaveNetworkButton.UseVisualStyleBackColor = true;
            this.SaveNetworkButton.Click += new System.EventHandler(this.SaveNetworkButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(417, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(603, 407);
            this.listBox1.TabIndex = 2;
            // 
            // GetClassButton
            // 
            this.GetClassButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.GetClassButton.Location = new System.Drawing.Point(14, 457);
            this.GetClassButton.Name = "GetClassButton";
            this.GetClassButton.Size = new System.Drawing.Size(386, 47);
            this.GetClassButton.TabIndex = 1;
            this.GetClassButton.Text = "Спросить";
            this.GetClassButton.UseVisualStyleBackColor = true;
            this.GetClassButton.Click += new System.EventHandler(this.GetClassButton_Click);
            // 
            // CarsChekedBox
            // 
            this.CarsChekedBox.CheckOnClick = true;
            this.CarsChekedBox.FormattingEnabled = true;
            this.CarsChekedBox.Location = new System.Drawing.Point(14, 27);
            this.CarsChekedBox.Name = "CarsChekedBox";
            this.CarsChekedBox.Size = new System.Drawing.Size(386, 409);
            this.CarsChekedBox.TabIndex = 0;
            // 
            // TeachButton
            // 
            this.TeachButton.Location = new System.Drawing.Point(20, 17);
            this.TeachButton.Name = "TeachButton";
            this.TeachButton.Size = new System.Drawing.Size(166, 46);
            this.TeachButton.TabIndex = 0;
            this.TeachButton.Text = "Обучить сеть";
            this.TeachButton.UseVisualStyleBackColor = true;
            this.TeachButton.Click += new System.EventHandler(this.TeachButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Location = new System.Drawing.Point(625, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 754);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1130, 793);
            this.MinimumSize = new System.Drawing.Size(1130, 793);
            this.Name = "Form1";
            this.Text = "Neural Network";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CarNametextBox;
        private System.Windows.Forms.ComboBox DriveComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ClearanceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PassCountTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PowerTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TypeAutoComboBox;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.DataGridView CarTable;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox NotNormalize;
        private System.Windows.Forms.CheckBox Normalize;
        private System.Windows.Forms.Button TeachButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GetClassButton;
        private System.Windows.Forms.CheckedListBox CarsChekedBox;
        private System.Windows.Forms.Label ResultTeachingLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label SumErrorLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button LoadNetworkButton;
        private System.Windows.Forms.Button SaveNetworkButton;
        private System.Windows.Forms.Label label11;
    }
}

