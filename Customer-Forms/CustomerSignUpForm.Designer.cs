
namespace test
{
    partial class CustomerSignUpForm
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
            this.CElabel = new System.Windows.Forms.Label();
            this.CUserTextBox = new System.Windows.Forms.TextBox();
            this.CLNLabel = new System.Windows.Forms.Label();
            this.CFNLabel = new System.Windows.Forms.Label();
            this.CLNTextBox = new System.Windows.Forms.TextBox();
            this.CFNTextBox = new System.Windows.Forms.TextBox();
            this.CPassLabel = new System.Windows.Forms.Label();
            this.CPassTextBox = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.CPNTextBox = new System.Windows.Forms.TextBox();
            this.CPNLabel = new System.Windows.Forms.Label();
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
            this.titlePanel.TabIndex = 3;
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
            this.signInLabel.Size = new System.Drawing.Size(216, 32);
            this.signInLabel.TabIndex = 1;
            this.signInLabel.Text = " Customer Sign Up";
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
            // CElabel
            // 
            this.CElabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CElabel.AutoSize = true;
            this.CElabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CElabel.Location = new System.Drawing.Point(433, 166);
            this.CElabel.Name = "CElabel";
            this.CElabel.Size = new System.Drawing.Size(70, 17);
            this.CElabel.TabIndex = 19;
            this.CElabel.Text = "Username:";
            // 
            // CUserTextBox
            // 
            this.CUserTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CUserTextBox.Location = new System.Drawing.Point(436, 192);
            this.CUserTextBox.Name = "CUserTextBox";
            this.CUserTextBox.Size = new System.Drawing.Size(185, 20);
            this.CUserTextBox.TabIndex = 17;
            // 
            // CLNLabel
            // 
            this.CLNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLNLabel.AutoSize = true;
            this.CLNLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLNLabel.Location = new System.Drawing.Point(139, 241);
            this.CLNLabel.Name = "CLNLabel";
            this.CLNLabel.Size = new System.Drawing.Size(73, 17);
            this.CLNLabel.TabIndex = 16;
            this.CLNLabel.Text = "Last Name:";
            // 
            // CFNLabel
            // 
            this.CFNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CFNLabel.AutoSize = true;
            this.CFNLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFNLabel.Location = new System.Drawing.Point(139, 166);
            this.CFNLabel.Name = "CFNLabel";
            this.CFNLabel.Size = new System.Drawing.Size(74, 17);
            this.CFNLabel.TabIndex = 15;
            this.CFNLabel.Text = "First Name:";
            // 
            // CLNTextBox
            // 
            this.CLNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CLNTextBox.Location = new System.Drawing.Point(142, 276);
            this.CLNTextBox.Name = "CLNTextBox";
            this.CLNTextBox.Size = new System.Drawing.Size(185, 20);
            this.CLNTextBox.TabIndex = 14;
            // 
            // CFNTextBox
            // 
            this.CFNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CFNTextBox.Location = new System.Drawing.Point(142, 192);
            this.CFNTextBox.Name = "CFNTextBox";
            this.CFNTextBox.Size = new System.Drawing.Size(185, 20);
            this.CFNTextBox.TabIndex = 13;
            // 
            // CPassLabel
            // 
            this.CPassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CPassLabel.AutoSize = true;
            this.CPassLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPassLabel.Location = new System.Drawing.Point(433, 241);
            this.CPassLabel.Name = "CPassLabel";
            this.CPassLabel.Size = new System.Drawing.Size(67, 17);
            this.CPassLabel.TabIndex = 22;
            this.CPassLabel.Text = "Password:";
            this.CPassLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CPassTextBox
            // 
            this.CPassTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CPassTextBox.Location = new System.Drawing.Point(436, 267);
            this.CPassTextBox.Name = "CPassTextBox";
            this.CPassTextBox.Size = new System.Drawing.Size(185, 20);
            this.CPassTextBox.TabIndex = 21;
            this.CPassTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(531, 346);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(90, 29);
            this.signUpButton.TabIndex = 23;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // CPNTextBox
            // 
            this.CPNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CPNTextBox.Location = new System.Drawing.Point(142, 355);
            this.CPNTextBox.Name = "CPNTextBox";
            this.CPNTextBox.Size = new System.Drawing.Size(185, 20);
            this.CPNTextBox.TabIndex = 18;
            // 
            // CPNLabel
            // 
            this.CPNLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CPNLabel.AutoSize = true;
            this.CPNLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPNLabel.Location = new System.Drawing.Point(139, 320);
            this.CPNLabel.Name = "CPNLabel";
            this.CPNLabel.Size = new System.Drawing.Size(99, 17);
            this.CPNLabel.TabIndex = 20;
            this.CPNLabel.Text = "Phone Number:";
            // 
            // CustomerSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.CPassLabel);
            this.Controls.Add(this.CPassTextBox);
            this.Controls.Add(this.CPNLabel);
            this.Controls.Add(this.CElabel);
            this.Controls.Add(this.CPNTextBox);
            this.Controls.Add(this.CUserTextBox);
            this.Controls.Add(this.CLNLabel);
            this.Controls.Add(this.CFNLabel);
            this.Controls.Add(this.CLNTextBox);
            this.Controls.Add(this.CFNTextBox);
            this.Controls.Add(this.titlePanel);
            this.Name = "CustomerSignUpForm";
            this.Text = "CustomerSignUpForm";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label CElabel;
        private System.Windows.Forms.TextBox CUserTextBox;
        private System.Windows.Forms.Label CLNLabel;
        private System.Windows.Forms.Label CFNLabel;
        private System.Windows.Forms.TextBox CLNTextBox;
        private System.Windows.Forms.TextBox CFNTextBox;
        private System.Windows.Forms.Label CPassLabel;
        private System.Windows.Forms.TextBox CPassTextBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox CPNTextBox;
        private System.Windows.Forms.Label CPNLabel;
    }
}