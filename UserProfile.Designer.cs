namespace Library_management_system
{
    partial class UserProfile
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
            txtFullName = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMembershipType = new TextBox();
            txtMemberId = new TextBox();
            txtGender = new TextBox();
            txtNIC = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            btnUpdate = new Button();
            btnText = new Button();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(123, 122);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(204, 23);
            txtFullName.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 70, 102);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icon24;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(41, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(144, 32);
            button1.TabIndex = 3;
            button1.Text = "My Profile";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 124);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 4;
            label1.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 166);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "Member ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 208);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 247);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "NIC :";
            // 
            // txtMembershipType
            // 
            txtMembershipType.Location = new Point(505, 119);
            txtMembershipType.Margin = new Padding(3, 2, 3, 2);
            txtMembershipType.Name = "txtMembershipType";
            txtMembershipType.ReadOnly = true;
            txtMembershipType.Size = new Size(192, 23);
            txtMembershipType.TabIndex = 12;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(123, 164);
            txtMemberId.Margin = new Padding(3, 2, 3, 2);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(204, 23);
            txtMemberId.TabIndex = 13;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(123, 206);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(204, 23);
            txtGender.TabIndex = 14;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(123, 244);
            txtNIC.Margin = new Padding(3, 2, 3, 2);
            txtNIC.Name = "txtNIC";
            txtNIC.ReadOnly = true;
            txtNIC.Size = new Size(204, 23);
            txtNIC.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(346, 164);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 16;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(346, 122);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 17;
            label6.Text = "Membership Type :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(346, 198);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 18;
            label7.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(346, 244);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 19;
            label8.Text = "Phone No :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(505, 158);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(192, 23);
            txtEmail.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(505, 199);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(192, 23);
            txtAddress.TabIndex = 21;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(505, 240);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(192, 23);
            txtPhone.TabIndex = 22;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientInactiveCaption;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.Location = new Point(218, 304);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 40);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnText
            // 
            btnText.BackColor = SystemColors.GradientInactiveCaption;
            btnText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnText.Location = new Point(438, 304);
            btnText.Margin = new Padding(3, 2, 3, 2);
            btnText.Name = "btnText";
            btnText.Size = new Size(108, 40);
            btnText.TabIndex = 25;
            btnText.Text = "Exit";
            btnText.UseVisualStyleBackColor = false;
            btnText.Click += btnText_Click;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 361);
            Controls.Add(btnText);
            Controls.Add(btnUpdate);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNIC);
            Controls.Add(txtGender);
            Controls.Add(txtMemberId);
            Controls.Add(txtMembershipType);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtFullName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserProfile";
            Text = "My Profile";
            Load += Form4_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMembershipType;
        private TextBox txtMemberId;
        private TextBox txtGender;
        private TextBox txtNIC;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Button btnUpdate;
        private Button btnText;
    }
}