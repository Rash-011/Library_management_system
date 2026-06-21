namespace Library_management_system
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            fgtpassword = new TextBox();
            username = new TextBox();
            password = new TextBox();
            textBox8 = new TextBox();
            loginbtn = new Button();
            signupbtn = new Button();
            showpassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(433, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 440);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(28, 29, 33);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(54, 61);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 43);
            textBox1.TabIndex = 1;
            textBox1.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(28, 29, 33);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(54, 99);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 32);
            textBox2.TabIndex = 2;
            textBox2.Text = "Enter your account details\r\n\r\n";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(28, 29, 33);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(54, 134);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 39);
            textBox3.TabIndex = 3;
            textBox3.Text = "Username";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(28, 29, 33);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Sans Serif Collection", 7.799999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(54, 368);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 28);
            textBox4.TabIndex = 4;
            textBox4.Text = "Don't you have an account?\r\n";
            // 
            // fgtpassword
            // 
            fgtpassword.BackColor = Color.FromArgb(28, 29, 33);
            fgtpassword.BorderStyle = BorderStyle.None;
            fgtpassword.Cursor = Cursors.Hand;
            fgtpassword.Font = new Font("Sans Serif Collection", 7.799999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fgtpassword.ForeColor = Color.White;
            fgtpassword.Location = new Point(54, 244);
            fgtpassword.Margin = new Padding(3, 2, 3, 2);
            fgtpassword.Name = "fgtpassword";
            fgtpassword.Size = new Size(109, 28);
            fgtpassword.TabIndex = 5;
            fgtpassword.Text = "Forgot password?";
            fgtpassword.Click += fgtpassword_TextChanged;
            // 
            // username
            // 
            username.Location = new Point(54, 164);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Name = "username";
            username.Size = new Size(249, 23);
            username.TabIndex = 6;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(54, 220);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.Size = new Size(249, 23);
            password.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(28, 29, 33);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.ForeColor = Color.White;
            textBox8.Location = new Point(54, 189);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(94, 39);
            textBox8.TabIndex = 7;
            textBox8.Text = "Password";
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.FromArgb(158, 111, 224);
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.FlatAppearance.BorderSize = 0;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(54, 286);
            loginbtn.Margin = new Padding(3, 2, 3, 2);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(248, 26);
            loginbtn.TabIndex = 9;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = SystemColors.GrayText;
            signupbtn.Cursor = Cursors.Hand;
            signupbtn.FlatAppearance.BorderSize = 0;
            signupbtn.FlatStyle = FlatStyle.Flat;
            signupbtn.Font = new Font("Sans Serif Collection", 7.799999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupbtn.ForeColor = Color.White;
            signupbtn.Location = new Point(239, 368);
            signupbtn.Margin = new Padding(3, 2, 3, 2);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(64, 26);
            signupbtn.TabIndex = 10;
            signupbtn.Text = "Sign up";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showpassword.ForeColor = Color.White;
            showpassword.Location = new Point(197, 249);
            showpassword.Margin = new Padding(3, 2, 3, 2);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(107, 17);
            showpassword.TabIndex = 11;
            showpassword.Text = "show password";
            showpassword.UseVisualStyleBackColor = true;
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 33);
            ClientSize = new Size(861, 440);
            Controls.Add(showpassword);
            Controls.Add(signupbtn);
            Controls.Add(loginbtn);
            Controls.Add(password);
            Controls.Add(textBox8);
            Controls.Add(username);
            Controls.Add(textBox1);
            Controls.Add(fgtpassword);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox fgtpassword;
        private TextBox username;
        private TextBox password;
        private TextBox textBox8;
        private Button loginbtn;
        private Button signupbtn;
        private CheckBox showpassword;
    }
}