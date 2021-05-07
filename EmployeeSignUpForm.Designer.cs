
namespace test
{
    partial class EmployeeSignUpForm
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
            this.signUpButton = new System.Windows.Forms.Button();
            this.EPassLabel = new System.Windows.Forms.Label();
            this.EPassTextBox = new System.Windows.Forms.TextBox();
            this.EUserlabel = new System.Windows.Forms.Label();
            this.EUserTextBox = new System.Windows.Forms.TextBox();
            this.ELNLabel = new System.Windows.Forms.Label();
            this.EFNLabel = new System.Windows.Forms.Label();
            this.ELNTextBox = new System.Windows.Forms.TextBox();
            this.EFNTextBox = new System.Windows.Forms.TextBox();
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
            this.titlePanel.Size = new System.Drawing.Size(784, 123);
            this.titlePanel.TabIndex = 2;
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
            this.signInLabel.Size = new System.Drawing.Size(218, 32);
            this.signInLabel.TabIndex = 1;
            this.signInLabel.Text = " Employee Sign Up";
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
            this.signUpButton.Location = new System.Drawing.Point(548, 347);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(90, 29);
            this.signUpButton.TabIndex = 34;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // EPassLabel
            // 
            this.EPassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EPassLabel.AutoSize = true;
            this.EPassLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPassLabel.Location = new System.Drawing.Point(450, 242);
            this.EPassLabel.Name = "EPassLabel";
            this.EPassLabel.Size = new System.Drawing.Size(67, 17);
            this.EPassLabel.TabIndex = 33;
            this.EPassLabel.Text = "Password:";
            // 
            // EPassTextBox
            // 
            this.EPassTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EPassTextBox.Location = new System.Drawing.Point(453, 268);
            this.EPassTextBox.Name = "EPassTextBox";
            this.EPassTextBox.Size = new System.Drawing.Size(185, 20);
            this.EPassTextBox.TabIndex = 32;
            // 
            // EUserlabel
            // 
            this.EUserlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EUserlabel.AutoSize = true;
            this.EUserlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EUserlabel.Location = new System.Drawing.Point(450, 167);
            this.EUserlabel.Name = "EUserlabel";
            this.EUserlabel.Size = new System.Drawing.Size(70, 17);
            this.EUserlabel.TabIndex = 30;
            this.EUserlabel.Text = "Username:";
            // 
            // EUserTextBox
            // 
            this.EUserTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EUserTextBox.Location = new System.Drawing.Point(453, 193);
            this.EUserTextBox.Name = "EUserTextBox";
            this.EUserTextBox.Size = new System.Drawing.Size(185, 20);
            this.EUserTextBox.TabIndex = 28;
            // 
            // ELNLabel
            // 
            this.ELNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ELNLabel.AutoSize = true;
            this.ELNLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELNLabel.Location = new System.Drawing.Point(156, 242);
            this.ELNLabel.Name = "ELNLabel";
            this.ELNLabel.Size = new System.Drawing.Size(73, 17);
            this.ELNLabel.TabIndex = 27;
            this.ELNLabel.Text = "Last Name:";
            // 
            // EFNLabel
            // 
            this.EFNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EFNLabel.AutoSize = true;
            this.EFNLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EFNLabel.Location = new System.Drawing.Point(156, 167);
            this.EFNLabel.Name = "EFNLabel";
            this.EFNLabel.Size = new System.Drawing.Size(74, 17);
            this.EFNLabel.TabIndex = 26;
            this.EFNLabel.Text = "First Name:";
            // 
            // ELNTextBox
            // 
            this.ELNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ELNTextBox.Location = new System.Drawing.Point(159, 277);
            this.ELNTextBox.Name = "ELNTextBox";
            this.ELNTextBox.Size = new System.Drawing.Size(185, 20);
            this.ELNTextBox.TabIndex = 25;
            // 
            // EFNTextBox
            // 
            this.EFNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EFNTextBox.Location = new System.Drawing.Point(159, 193);
            this.EFNTextBox.Name = "EFNTextBox";
            this.EFNTextBox.Size = new System.Drawing.Size(185, 20);
            this.EFNTextBox.TabIndex = 24;
            // 
            // EmployeeSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.EPassLabel);
            this.Controls.Add(this.EPassTextBox);
            this.Controls.Add(this.EUserlabel);
            this.Controls.Add(this.EUserTextBox);
            this.Controls.Add(this.ELNLabel);
            this.Controls.Add(this.EFNLabel);
            this.Controls.Add(this.ELNTextBox);
            this.Controls.Add(this.EFNTextBox);
            this.Controls.Add(this.titlePanel);
            this.Name = "EmployeeSignUpForm";
            this.Text = "EmployeeSignInForm";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label EPassLabel;
        private System.Windows.Forms.TextBox EPassTextBox;
        private System.Windows.Forms.Label EUserlabel;
        private System.Windows.Forms.TextBox EUserTextBox;
        private System.Windows.Forms.Label ELNLabel;
        private System.Windows.Forms.Label EFNLabel;
        private System.Windows.Forms.TextBox ELNTextBox;
        private System.Windows.Forms.TextBox EFNTextBox;
    }
}