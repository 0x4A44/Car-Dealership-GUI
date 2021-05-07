
namespace test
{
    partial class adminDelete
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
            this.button1 = new System.Windows.Forms.Button();
            this.transidLabel = new System.Windows.Forms.Label();
            this.EdeleteVehicleButton = new System.Windows.Forms.Button();
            this.deleteVComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteVDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deleteVDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 57;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transidLabel
            // 
            this.transidLabel.AutoSize = true;
            this.transidLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transidLabel.Location = new System.Drawing.Point(907, 142);
            this.transidLabel.Name = "transidLabel";
            this.transidLabel.Size = new System.Drawing.Size(168, 17);
            this.transidLabel.TabIndex = 56;
            this.transidLabel.Text = "Choose a Vehicle ID Below: ";
            // 
            // EdeleteVehicleButton
            // 
            this.EdeleteVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EdeleteVehicleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.EdeleteVehicleButton.FlatAppearance.BorderSize = 0;
            this.EdeleteVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EdeleteVehicleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdeleteVehicleButton.ForeColor = System.Drawing.Color.White;
            this.EdeleteVehicleButton.Location = new System.Drawing.Point(929, 265);
            this.EdeleteVehicleButton.Name = "EdeleteVehicleButton";
            this.EdeleteVehicleButton.Size = new System.Drawing.Size(116, 29);
            this.EdeleteVehicleButton.TabIndex = 55;
            this.EdeleteVehicleButton.Text = "Delete Vehicle";
            this.EdeleteVehicleButton.UseVisualStyleBackColor = false;
            this.EdeleteVehicleButton.Click += new System.EventHandler(this.EdeleteVehicleButton_Click);
            // 
            // deleteVComboBox
            // 
            this.deleteVComboBox.FormattingEnabled = true;
            this.deleteVComboBox.Location = new System.Drawing.Point(929, 181);
            this.deleteVComboBox.Name = "deleteVComboBox";
            this.deleteVComboBox.Size = new System.Drawing.Size(116, 21);
            this.deleteVComboBox.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(532, 37);
            this.label9.TabIndex = 53;
            this.label9.Text = "Choose a Vehicle to Delete from the System";
            // 
            // deleteVDataGridView
            // 
            this.deleteVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteVDataGridView.Location = new System.Drawing.Point(4, 78);
            this.deleteVDataGridView.Name = "deleteVDataGridView";
            this.deleteVDataGridView.Size = new System.Drawing.Size(876, 355);
            this.deleteVDataGridView.TabIndex = 52;
            // 
            // adminDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transidLabel);
            this.Controls.Add(this.EdeleteVehicleButton);
            this.Controls.Add(this.deleteVComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteVDataGridView);
            this.Name = "adminDelete";
            this.Size = new System.Drawing.Size(1092, 450);
            ((System.ComponentModel.ISupportInitialize)(this.deleteVDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label transidLabel;
        private System.Windows.Forms.Button EdeleteVehicleButton;
        private System.Windows.Forms.ComboBox deleteVComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView deleteVDataGridView;
    }
}
