
namespace test
{
    partial class CPotentialSale
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
            this.backButton = new System.Windows.Forms.Button();
            this.transidLabel = new System.Windows.Forms.Label();
            this.CRemoveVehicleButton = new System.Windows.Forms.Button();
            this.potentComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CpotentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CpotentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(16, 25);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(116, 29);
            this.backButton.TabIndex = 57;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // transidLabel
            // 
            this.transidLabel.AutoSize = true;
            this.transidLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transidLabel.Location = new System.Drawing.Point(906, 170);
            this.transidLabel.Name = "transidLabel";
            this.transidLabel.Size = new System.Drawing.Size(164, 17);
            this.transidLabel.TabIndex = 56;
            this.transidLabel.Text = "Choose a Potential Sale ID:";
            this.transidLabel.Click += new System.EventHandler(this.transidLabel_Click);
            // 
            // CRemoveVehicleButton
            // 
            this.CRemoveVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CRemoveVehicleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.CRemoveVehicleButton.FlatAppearance.BorderSize = 0;
            this.CRemoveVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CRemoveVehicleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRemoveVehicleButton.ForeColor = System.Drawing.Color.White;
            this.CRemoveVehicleButton.Location = new System.Drawing.Point(928, 250);
            this.CRemoveVehicleButton.Name = "CRemoveVehicleButton";
            this.CRemoveVehicleButton.Size = new System.Drawing.Size(116, 29);
            this.CRemoveVehicleButton.TabIndex = 55;
            this.CRemoveVehicleButton.Text = "Remove Vehicle";
            this.CRemoveVehicleButton.UseVisualStyleBackColor = false;
            this.CRemoveVehicleButton.Click += new System.EventHandler(this.CRemoveVehicleButton_Click);
            // 
            // potentComboBox
            // 
            this.potentComboBox.FormattingEnabled = true;
            this.potentComboBox.Location = new System.Drawing.Point(928, 202);
            this.potentComboBox.Name = "potentComboBox";
            this.potentComboBox.Size = new System.Drawing.Size(116, 21);
            this.potentComboBox.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(424, 37);
            this.label9.TabIndex = 53;
            this.label9.Text = "View Potential Vehicle Sales Below";
            // 
            // CpotentDataGridView
            // 
            this.CpotentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CpotentDataGridView.Location = new System.Drawing.Point(4, 78);
            this.CpotentDataGridView.Name = "CpotentDataGridView";
            this.CpotentDataGridView.Size = new System.Drawing.Size(876, 355);
            this.CpotentDataGridView.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(885, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Remove Vehicle Below:";
            // 
            // CPotentialSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.transidLabel);
            this.Controls.Add(this.CRemoveVehicleButton);
            this.Controls.Add(this.potentComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CpotentDataGridView);
            this.Name = "CPotentialSale";
            this.Size = new System.Drawing.Size(1092, 450);
            ((System.ComponentModel.ISupportInitialize)(this.CpotentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label transidLabel;
        private System.Windows.Forms.Button CRemoveVehicleButton;
        private System.Windows.Forms.ComboBox potentComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView CpotentDataGridView;
        private System.Windows.Forms.Label label1;
    }
}
