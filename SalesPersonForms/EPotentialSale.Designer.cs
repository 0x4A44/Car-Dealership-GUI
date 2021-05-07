
namespace test
{
    partial class EPotentialSale
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
            this.potentDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.potentComboBox = new System.Windows.Forms.ComboBox();
            this.EsellVehicleButton = new System.Windows.Forms.Button();
            this.transidLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.potentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // potentDataGridView
            // 
            this.potentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.potentDataGridView.Location = new System.Drawing.Point(8, 81);
            this.potentDataGridView.Name = "potentDataGridView";
            this.potentDataGridView.Size = new System.Drawing.Size(876, 355);
            this.potentDataGridView.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(244, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(424, 37);
            this.label9.TabIndex = 47;
            this.label9.Text = "View Potential Vehicle Sales Below";
            // 
            // potentComboBox
            // 
            this.potentComboBox.FormattingEnabled = true;
            this.potentComboBox.Location = new System.Drawing.Point(933, 184);
            this.potentComboBox.Name = "potentComboBox";
            this.potentComboBox.Size = new System.Drawing.Size(116, 21);
            this.potentComboBox.TabIndex = 48;
            // 
            // EsellVehicleButton
            // 
            this.EsellVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EsellVehicleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.EsellVehicleButton.FlatAppearance.BorderSize = 0;
            this.EsellVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EsellVehicleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsellVehicleButton.ForeColor = System.Drawing.Color.White;
            this.EsellVehicleButton.Location = new System.Drawing.Point(933, 280);
            this.EsellVehicleButton.Name = "EsellVehicleButton";
            this.EsellVehicleButton.Size = new System.Drawing.Size(116, 29);
            this.EsellVehicleButton.TabIndex = 49;
            this.EsellVehicleButton.Text = "Sell Vehicle";
            this.EsellVehicleButton.UseVisualStyleBackColor = false;
            this.EsellVehicleButton.Click += new System.EventHandler(this.EsellVehicleButton_Click);
            // 
            // transidLabel
            // 
            this.transidLabel.AutoSize = true;
            this.transidLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transidLabel.Location = new System.Drawing.Point(890, 141);
            this.transidLabel.Name = "transidLabel";
            this.transidLabel.Size = new System.Drawing.Size(202, 17);
            this.transidLabel.TabIndex = 50;
            this.transidLabel.Text = "Choose a Potential Sale ID Below:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 51;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EPotentialSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transidLabel);
            this.Controls.Add(this.EsellVehicleButton);
            this.Controls.Add(this.potentComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.potentDataGridView);
            this.Name = "EPotentialSale";
            this.Size = new System.Drawing.Size(1092, 450);
            ((System.ComponentModel.ISupportInitialize)(this.potentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView potentDataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox potentComboBox;
        private System.Windows.Forms.Button EsellVehicleButton;
        private System.Windows.Forms.Label transidLabel;
        private System.Windows.Forms.Button button1;
    }
}
