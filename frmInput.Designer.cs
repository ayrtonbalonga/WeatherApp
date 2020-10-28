namespace Weatherapp
{
    partial class frmInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label sDateLabel;
            System.Windows.Forms.Label humidityLabel;
            System.Windows.Forms.Label maxTempLabel;
            System.Windows.Forms.Label minTempLabel;
            System.Windows.Forms.Label precipitationLabel;
            System.Windows.Forms.Label windSpeedLabel;
            System.Windows.Forms.Label label2;
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.humidityTextBox = new System.Windows.Forms.TextBox();
            this.maxTempTextBox = new System.Windows.Forms.TextBox();
            this.minTempTextBox = new System.Windows.Forms.TextBox();
            this.precipitationTextBox = new System.Windows.Forms.TextBox();
            this.windSpeedTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.weatherDataGridView = new System.Windows.Forms.DataGridView();
            cityLabel = new System.Windows.Forms.Label();
            sDateLabel = new System.Windows.Forms.Label();
            humidityLabel = new System.Windows.Forms.Label();
            maxTempLabel = new System.Windows.Forms.Label();
            minTempLabel = new System.Windows.Forms.Label();
            precipitationLabel = new System.Windows.Forms.Label();
            windSpeedLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(306, 365);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 40;
            cityLabel.Text = "City:";
            // 
            // sDateLabel
            // 
            sDateLabel.AutoSize = true;
            sDateLabel.Location = new System.Drawing.Point(306, 392);
            sDateLabel.Name = "sDateLabel";
            sDateLabel.Size = new System.Drawing.Size(33, 13);
            sDateLabel.TabIndex = 42;
            sDateLabel.Text = "Date:";
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.Location = new System.Drawing.Point(306, 417);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new System.Drawing.Size(50, 13);
            humidityLabel.TabIndex = 44;
            humidityLabel.Text = "Humidity:";
            // 
            // maxTempLabel
            // 
            maxTempLabel.AutoSize = true;
            maxTempLabel.Location = new System.Drawing.Point(306, 443);
            maxTempLabel.Name = "maxTempLabel";
            maxTempLabel.Size = new System.Drawing.Size(60, 13);
            maxTempLabel.TabIndex = 46;
            maxTempLabel.Text = "Max Temp:";
            // 
            // minTempLabel
            // 
            minTempLabel.AutoSize = true;
            minTempLabel.Location = new System.Drawing.Point(306, 469);
            minTempLabel.Name = "minTempLabel";
            minTempLabel.Size = new System.Drawing.Size(57, 13);
            minTempLabel.TabIndex = 48;
            minTempLabel.Text = "Min Temp:";
            // 
            // precipitationLabel
            // 
            precipitationLabel.AutoSize = true;
            precipitationLabel.Location = new System.Drawing.Point(306, 495);
            precipitationLabel.Name = "precipitationLabel";
            precipitationLabel.Size = new System.Drawing.Size(68, 13);
            precipitationLabel.TabIndex = 50;
            precipitationLabel.Text = "Precipitation:";
            // 
            // windSpeedLabel
            // 
            windSpeedLabel.AutoSize = true;
            windSpeedLabel.Location = new System.Drawing.Point(306, 521);
            windSpeedLabel.Name = "windSpeedLabel";
            windSpeedLabel.Size = new System.Drawing.Size(69, 13);
            windSpeedLabel.TabIndex = 52;
            windSpeedLabel.Text = "Wind Speed:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(306, 330);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(19, 13);
            label2.TabIndex = 58;
            label2.Text = "Id:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(420, 660);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Input Information";
            // 
            // sDateDateTimePicker
            // 
            this.sDateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.sDateDateTimePicker.Location = new System.Drawing.Point(381, 388);
            this.sDateDateTimePicker.Name = "sDateDateTimePicker";
            this.sDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.sDateDateTimePicker.TabIndex = 43;
            // 
            // humidityTextBox
            // 
            this.humidityTextBox.Location = new System.Drawing.Point(381, 414);
            this.humidityTextBox.Name = "humidityTextBox";
            this.humidityTextBox.Size = new System.Drawing.Size(200, 20);
            this.humidityTextBox.TabIndex = 45;
            // 
            // maxTempTextBox
            // 
            this.maxTempTextBox.Location = new System.Drawing.Point(381, 440);
            this.maxTempTextBox.Name = "maxTempTextBox";
            this.maxTempTextBox.Size = new System.Drawing.Size(200, 20);
            this.maxTempTextBox.TabIndex = 47;
            // 
            // minTempTextBox
            // 
            this.minTempTextBox.Location = new System.Drawing.Point(381, 466);
            this.minTempTextBox.Name = "minTempTextBox";
            this.minTempTextBox.Size = new System.Drawing.Size(200, 20);
            this.minTempTextBox.TabIndex = 49;
            // 
            // precipitationTextBox
            // 
            this.precipitationTextBox.Location = new System.Drawing.Point(381, 492);
            this.precipitationTextBox.Name = "precipitationTextBox";
            this.precipitationTextBox.Size = new System.Drawing.Size(200, 20);
            this.precipitationTextBox.TabIndex = 51;
            // 
            // windSpeedTextBox
            // 
            this.windSpeedTextBox.Location = new System.Drawing.Point(381, 518);
            this.windSpeedTextBox.Name = "windSpeedTextBox";
            this.windSpeedTextBox.Size = new System.Drawing.Size(200, 20);
            this.windSpeedTextBox.TabIndex = 53;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 567);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(487, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(381, 567);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Cape town",
            "Port-Elizabeth",
            "Pretoria",
            "Johanesbourg",
            "Durban"});
            this.cbCity.Location = new System.Drawing.Point(381, 357);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(200, 21);
            this.cbCity.TabIndex = 57;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(381, 323);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(200, 20);
            this.IdtextBox.TabIndex = 59;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(592, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // weatherDataGridView
            // 
            this.weatherDataGridView.AllowUserToOrderColumns = true;
            this.weatherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weatherDataGridView.Location = new System.Drawing.Point(38, 73);
            this.weatherDataGridView.Name = "weatherDataGridView";
            this.weatherDataGridView.Size = new System.Drawing.Size(846, 225);
            this.weatherDataGridView.TabIndex = 61;
            this.weatherDataGridView.DoubleClick += new System.EventHandler(this.weatherDataGridView_DoubleClick);
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 752);
            this.Controls.Add(this.weatherDataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(cityLabel);
            this.Controls.Add(sDateLabel);
            this.Controls.Add(this.sDateDateTimePicker);
            this.Controls.Add(humidityLabel);
            this.Controls.Add(this.humidityTextBox);
            this.Controls.Add(maxTempLabel);
            this.Controls.Add(this.maxTempTextBox);
            this.Controls.Add(minTempLabel);
            this.Controls.Add(this.minTempTextBox);
            this.Controls.Add(precipitationLabel);
            this.Controls.Add(this.precipitationTextBox);
            this.Controls.Add(windSpeedLabel);
            this.Controls.Add(this.windSpeedTextBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "frmInput";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker sDateDateTimePicker;
        private System.Windows.Forms.TextBox humidityTextBox;
        private System.Windows.Forms.TextBox maxTempTextBox;
        private System.Windows.Forms.TextBox minTempTextBox;
        private System.Windows.Forms.TextBox precipitationTextBox;
        private System.Windows.Forms.TextBox windSpeedTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView weatherDataGridView;
    }
}