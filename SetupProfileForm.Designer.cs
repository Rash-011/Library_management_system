namespace Library_management_system
{
    partial class SetupProfileForm
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
            label1 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 65);
            label1.Name = "label1";
            label1.Size = new Size(265, 46);
            label1.TabIndex = 1;
            label1.Text = "Reset Password";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(239, 229, 255);
            txtFullName.Location = new Point(55, 258);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Rasika Prabath";
            txtFullName.Size = new Size(316, 27);
            txtFullName.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 233);
            label3.Name = "label3";
            label3.Size = new Size(91, 22);
            label3.TabIndex = 34;
            label3.Text = "Full Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(239, 229, 255);
            textBox2.Location = new Point(55, 334);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Rasika123";
            textBox2.Size = new Size(316, 27);
            textBox2.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 309);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 36;
            label2.Text = "New User Name";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(239, 229, 255);
            textBox3.Location = new Point(55, 419);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter-6-digit password";
            textBox3.Size = new Size(316, 27);
            textBox3.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(55, 394);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 38;
            label4.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(239, 229, 255);
            textBox4.Location = new Point(55, 508);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Re-enter password";
            textBox4.Size = new Size(316, 27);
            textBox4.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(55, 483);
            label5.Name = "label5";
            label5.Size = new Size(164, 22);
            label5.TabIndex = 40;
            label5.Text = "Re-enter Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(72, 46, 126);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(55, 570);
            button1.Name = "button1";
            button1.Size = new Size(316, 55);
            button1.TabIndex = 42;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(55, 111);
            label7.Name = "label7";
            label7.Size = new Size(378, 20);
            label7.TabIndex = 44;
            label7.Text = "No worries, Add your own username and password here";
            label7.Click += label7_Click;
            // 
            // SetupProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(91, 56, 150);
            ClientSize = new Size(491, 666);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(91, 56, 150);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SetupProfileForm";
            Text = "SetupProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtFullName;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Label label7;
    }
}