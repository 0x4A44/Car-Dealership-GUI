
namespace test
{
    partial class eAddCar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.makeComboBox = new System.Windows.Forms.ComboBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.lotComboBox = new System.Windows.Forms.ComboBox();
            this.lotLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 46);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(576, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(355, 32);
            this.label9.TabIndex = 46;
            this.label9.Text = "View and Search Vehicles Below";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Vehicle Below";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(226, 94);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(116, 21);
            this.colorComboBox.TabIndex = 43;
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.yearComboBox.Location = new System.Drawing.Point(34, 255);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(116, 21);
            this.yearComboBox.TabIndex = 42;
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(34, 175);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(116, 21);
            this.modelComboBox.TabIndex = 41;
            // 
            // makeComboBox
            // 
            this.makeComboBox.FormattingEnabled = true;
            this.makeComboBox.Location = new System.Drawing.Point(34, 94);
            this.makeComboBox.Name = "makeComboBox";
            this.makeComboBox.Size = new System.Drawing.Size(116, 21);
            this.makeComboBox.TabIndex = 40;
            this.makeComboBox.SelectedIndexChanged += new System.EventHandler(this.makeComboBox_SelectedIndexChanged);
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(226, 255);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(116, 20);
            this.mileageTextBox.TabIndex = 39;
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageLabel.Location = new System.Drawing.Point(223, 221);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(55, 17);
            this.mileageLabel.TabIndex = 38;
            this.mileageLabel.Text = "Mileage";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(31, 221);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(33, 17);
            this.yearLabel.TabIndex = 37;
            this.yearLabel.Text = "Year";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(226, 176);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(116, 20);
            this.priceTextBox.TabIndex = 36;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(223, 142);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 17);
            this.priceLabel.TabIndex = 35;
            this.priceLabel.Text = "Price";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(223, 60);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(40, 17);
            this.colorLabel.TabIndex = 34;
            this.colorLabel.Text = "Color";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(31, 142);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 17);
            this.modelLabel.TabIndex = 33;
            this.modelLabel.Text = "Model";
            this.modelLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeLabel.Location = new System.Drawing.Point(31, 60);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(40, 17);
            this.makeLabel.TabIndex = 32;
            this.makeLabel.Text = "Make";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Controls.Add(this.addVehicleButton);
            this.panel2.Controls.Add(this.lotComboBox);
            this.panel2.Controls.Add(this.lotLabel);
            this.panel2.Controls.Add(this.modelLabel);
            this.panel2.Controls.Add(this.mileageTextBox);
            this.panel2.Controls.Add(this.colorComboBox);
            this.panel2.Controls.Add(this.mileageLabel);
            this.panel2.Controls.Add(this.modelComboBox);
            this.panel2.Controls.Add(this.priceTextBox);
            this.panel2.Controls.Add(this.yearComboBox);
            this.panel2.Controls.Add(this.priceLabel);
            this.panel2.Controls.Add(this.makeLabel);
            this.panel2.Controls.Add(this.makeComboBox);
            this.panel2.Controls.Add(this.yearLabel);
            this.panel2.Controls.Add(this.colorLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 404);
            this.panel2.TabIndex = 44;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(34, 19);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(101, 26);
            this.refreshButton.TabIndex = 47;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addVehicleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.addVehicleButton.FlatAppearance.BorderSize = 0;
            this.addVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVehicleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicleButton.ForeColor = System.Drawing.Color.White;
            this.addVehicleButton.Location = new System.Drawing.Point(226, 325);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(116, 29);
            this.addVehicleButton.TabIndex = 46;
            this.addVehicleButton.Text = "Add Vehicle";
            this.addVehicleButton.UseVisualStyleBackColor = false;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // lotComboBox
            // 
            this.lotComboBox.FormattingEnabled = true;
            this.lotComboBox.Location = new System.Drawing.Point(34, 332);
            this.lotComboBox.Name = "lotComboBox";
            this.lotComboBox.Size = new System.Drawing.Size(116, 21);
            this.lotComboBox.TabIndex = 45;
            // 
            // lotLabel
            // 
            this.lotLabel.AutoSize = true;
            this.lotLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotLabel.Location = new System.Drawing.Point(31, 298);
            this.lotLabel.Name = "lotLabel";
            this.lotLabel.Size = new System.Drawing.Size(26, 17);
            this.lotLabel.TabIndex = 44;
            this.lotLabel.Text = "Lot";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 304);
            this.dataGridView1.TabIndex = 45;
            // 
            // eAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "eAddCar";
            this.Size = new System.Drawing.Size(1092, 450);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox lotComboBox;
        private System.Windows.Forms.Label lotLabel;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button refreshButton;
    }
}
