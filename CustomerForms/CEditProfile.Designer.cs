
namespace test
{
    partial class CEditProfile
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
            this.signInLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.CLNLabel = new System.Windows.Forms.Label();
            this.CLNTextBox = new System.Windows.Forms.TextBox();
            this.nameChangeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.titlePanel.Controls.Add(this.signInLabel);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(797, 123);
            this.titlePanel.TabIndex = 4;
            // 
            // signInLabel
            // 
            this.signInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.ForeColor = System.Drawing.Color.White;
            this.signInLabel.Location = new System.Drawing.Point(12, 70);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(247, 32);
            this.signInLabel.TabIndex = 1;
            this.signInLabel.Text = " Customer Edit Profile";
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
            // CLNLabel
            // 
            this.CLNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLNLabel.AutoSize = true;
            this.CLNLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLNLabel.Location = new System.Drawing.Point(297, 224);
            this.CLNLabel.Name = "CLNLabel";
            this.CLNLabel.Size = new System.Drawing.Size(73, 17);
            this.CLNLabel.TabIndex = 18;
            this.CLNLabel.Text = "Last Name:";
            // 
            // CLNTextBox
            // 
            this.CLNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLNTextBox.Location = new System.Drawing.Point(300, 259);
            this.CLNTextBox.Name = "CLNTextBox";
            this.CLNTextBox.Size = new System.Drawing.Size(185, 20);
            this.CLNTextBox.TabIndex = 17;
            // 
            // nameChangeButton
            // 
            this.nameChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.nameChangeButton.FlatAppearance.BorderSize = 0;
            this.nameChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameChangeButton.ForeColor = System.Drawing.Color.White;
            this.nameChangeButton.Location = new System.Drawing.Point(395, 321);
            this.nameChangeButton.Name = "nameChangeButton";
            this.nameChangeButton.Size = new System.Drawing.Size(90, 29);
            this.nameChangeButton.TabIndex = 24;
            this.nameChangeButton.Text = "Submit";
            this.nameChangeButton.UseVisualStyleBackColor = false;
            this.nameChangeButton.Click += new System.EventHandler(this.nameChangeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Edit Last Name Below:";
            // 
            // CEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameChangeButton);
            this.Controls.Add(this.CLNLabel);
            this.Controls.Add(this.CLNTextBox);
            this.Controls.Add(this.titlePanel);
            this.Name = "CEditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEditProfile";
            this.Deactivate += new System.EventHandler(this.CEditProfile_Deactivate);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label CLNLabel;
        private System.Windows.Forms.TextBox CLNTextBox;
        private System.Windows.Forms.Button nameChangeButton;
        private System.Windows.Forms.Label label1;
    }
}