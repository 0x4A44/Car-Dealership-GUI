
namespace test
{
    partial class addCarLotForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lotLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.ZipcodeLabel = new System.Windows.Forms.Label();
            this.ZipcodeTextBox = new System.Windows.Forms.TextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.Citylabel = new System.Windows.Forms.Label();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetNameLabel = new System.Windows.Forms.Label();
            this.StreetNumLabel = new System.Windows.Forms.Label();
            this.StreetNameTextBox = new System.Windows.Forms.TextBox();
            this.StreetNumTextBox = new System.Windows.Forms.TextBox();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.titlePanel.Controls.Add(this.lotLabel);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(784, 123);
            this.titlePanel.TabIndex = 4;
            // 
            // lotLabel
            // 
            this.lotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lotLabel.AutoSize = true;
            this.lotLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotLabel.ForeColor = System.Drawing.Color.White;
            this.lotLabel.Location = new System.Drawing.Point(12, 70);
            this.lotLabel.Name = "lotLabel";
            this.lotLabel.Size = new System.Drawing.Size(236, 32);
            this.lotLabel.TabIndex = 1;
            this.lotLabel.Text = "Add New Vehicle Lot";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(3, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(301, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = " ESU Auto Dealer";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(549, 343);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(90, 29);
            this.signUpButton.TabIndex = 34;
            this.signUpButton.Text = "Add Lot";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // ZipcodeLabel
            // 
            this.ZipcodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ZipcodeLabel.AutoSize = true;
            this.ZipcodeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipcodeLabel.Location = new System.Drawing.Point(451, 238);
            this.ZipcodeLabel.Name = "ZipcodeLabel";
            this.ZipcodeLabel.Size = new System.Drawing.Size(58, 17);
            this.ZipcodeLabel.TabIndex = 33;
            this.ZipcodeLabel.Text = "Zipcode:";
            // 
            // ZipcodeTextBox
            // 
            this.ZipcodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ZipcodeTextBox.Location = new System.Drawing.Point(454, 264);
            this.ZipcodeTextBox.Name = "ZipcodeTextBox";
            this.ZipcodeTextBox.Size = new System.Drawing.Size(185, 20);
            this.ZipcodeTextBox.TabIndex = 32;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.Location = new System.Drawing.Point(157, 317);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(40, 17);
            this.StateLabel.TabIndex = 31;
            this.StateLabel.Text = "State:";
            // 
            // Citylabel
            // 
            this.Citylabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Citylabel.AutoSize = true;
            this.Citylabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Citylabel.Location = new System.Drawing.Point(451, 163);
            this.Citylabel.Name = "Citylabel";
            this.Citylabel.Size = new System.Drawing.Size(32, 17);
            this.Citylabel.TabIndex = 30;
            this.Citylabel.Text = "City:";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StateTextBox.Location = new System.Drawing.Point(160, 352);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(185, 20);
            this.StateTextBox.TabIndex = 29;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CityTextBox.Location = new System.Drawing.Point(454, 189);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(185, 20);
            this.CityTextBox.TabIndex = 28;
            // 
            // StreetNameLabel
            // 
            this.StreetNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StreetNameLabel.AutoSize = true;
            this.StreetNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetNameLabel.Location = new System.Drawing.Point(157, 238);
            this.StreetNameLabel.Name = "StreetNameLabel";
            this.StreetNameLabel.Size = new System.Drawing.Size(84, 17);
            this.StreetNameLabel.TabIndex = 27;
            this.StreetNameLabel.Text = "Street Name:";
            // 
            // StreetNumLabel
            // 
            this.StreetNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StreetNumLabel.AutoSize = true;
            this.StreetNumLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetNumLabel.Location = new System.Drawing.Point(157, 163);
            this.StreetNumLabel.Name = "StreetNumLabel";
            this.StreetNumLabel.Size = new System.Drawing.Size(97, 17);
            this.StreetNumLabel.TabIndex = 26;
            this.StreetNumLabel.Text = "Street Number:";
            // 
            // StreetNameTextBox
            // 
            this.StreetNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StreetNameTextBox.Location = new System.Drawing.Point(160, 273);
            this.StreetNameTextBox.Name = "StreetNameTextBox";
            this.StreetNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.StreetNameTextBox.TabIndex = 25;
            // 
            // StreetNumTextBox
            // 
            this.StreetNumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StreetNumTextBox.Location = new System.Drawing.Point(160, 189);
            this.StreetNumTextBox.Name = "StreetNumTextBox";
            this.StreetNumTextBox.Size = new System.Drawing.Size(185, 20);
            this.StreetNumTextBox.TabIndex = 24;
            // 
            // addCarLotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.ZipcodeLabel);
            this.Controls.Add(this.ZipcodeTextBox);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.Citylabel);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.StreetNameLabel);
            this.Controls.Add(this.StreetNumLabel);
            this.Controls.Add(this.StreetNameTextBox);
            this.Controls.Add(this.StreetNumTextBox);
            this.Controls.Add(this.titlePanel);
            this.Name = "addCarLotForm";
            this.Text = "addCarLot";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lotLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label ZipcodeLabel;
        private System.Windows.Forms.TextBox ZipcodeTextBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label Citylabel;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label StreetNameLabel;
        private System.Windows.Forms.Label StreetNumLabel;
        private System.Windows.Forms.TextBox StreetNameTextBox;
        private System.Windows.Forms.TextBox StreetNumTextBox;
    }
}