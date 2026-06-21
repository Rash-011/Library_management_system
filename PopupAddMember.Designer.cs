namespace Library_management_system
{
    partial class PopupAddMember
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
            cmbGender = new ComboBox();
            cmbStatus = new ComboBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            txtDescription = new RichTextBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtDob = new TextBox();
            label8 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtNic = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpMembershipDate = new DateTimePicker();
            cmbMembershipType = new ComboBox();
            SuspendLayout();
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(390, 125);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(316, 28);
            cmbGender.TabIndex = 57;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Suspended", "Expired" });
            cmbStatus.Location = new Point(390, 370);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(316, 28);
            cmbStatus.TabIndex = 56;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(194, 773);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(141, 48);
            btnConfirm.TabIndex = 55;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(19, 773);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 48);
            btnCancel.TabIndex = 54;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(19, 623);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(316, 120);
            txtDescription.TabIndex = 53;
            txtDescription.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 598);
            label9.Name = "label9";
            label9.Size = new Size(180, 22);
            label9.TabIndex = 52;
            label9.Text = "Description (optional)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(390, 345);
            label11.Name = "label11";
            label11.Size = new Size(61, 22);
            label11.TabIndex = 49;
            label11.Text = "Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(390, 260);
            label12.Name = "label12";
            label12.Size = new Size(153, 22);
            label12.TabIndex = 47;
            label12.Text = "Membership Type";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(390, 179);
            label13.Name = "label13";
            label13.Size = new Size(150, 22);
            label13.TabIndex = 45;
            label13.Text = "Membership Date";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(390, 100);
            label14.Name = "label14";
            label14.Size = new Size(70, 22);
            label14.TabIndex = 44;
            label14.Text = "Gender";
            // 
            // txtDob
            // 
            txtDob.Location = new Point(19, 537);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(316, 27);
            txtDob.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 512);
            label8.Name = "label8";
            label8.Size = new Size(114, 22);
            label8.TabIndex = 42;
            label8.Text = "Date Of Birth";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(19, 452);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(316, 27);
            txtAddress.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 427);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 40;
            label7.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(19, 370);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(316, 27);
            txtPhone.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 345);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 38;
            label6.Text = "Phone Number";
            // 
            // txtNic
            // 
            txtNic.Location = new Point(19, 285);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(316, 27);
            txtNic.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 260);
            label5.Name = "label5";
            label5.Size = new Size(124, 22);
            label5.TabIndex = 36;
            label5.Text = "NIC/StudentID";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 27);
            txtEmail.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 179);
            label4.Name = "label4";
            label4.Size = new Size(60, 22);
            label4.TabIndex = 34;
            label4.Text = "E-mail";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(19, 125);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(316, 27);
            txtFullName.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 100);
            label3.Name = "label3";
            label3.Size = new Size(91, 22);
            label3.TabIndex = 32;
            label3.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 47);
            label2.Name = "label2";
            label2.Size = new Size(460, 18);
            label2.TabIndex = 31;
            label2.Text = "Fill in the details below to add the new member to the database.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Semi Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(196, 24);
            label1.TabIndex = 30;
            label1.Text = "Add New Members";
            // 
            // dtpMembershipDate
            // 
            dtpMembershipDate.Location = new Point(390, 204);
            dtpMembershipDate.Name = "dtpMembershipDate";
            dtpMembershipDate.Size = new Size(316, 27);
            dtpMembershipDate.TabIndex = 58;
            dtpMembershipDate.Value = new DateTime(2026, 6, 20, 11, 57, 48, 0);
            // 
            // cmbMembershipType
            // 
            cmbMembershipType.FormattingEnabled = true;
            cmbMembershipType.Items.AddRange(new object[] { "Student", "Staff ", "Public" });
            cmbMembershipType.Location = new Point(390, 284);
            cmbMembershipType.Name = "cmbMembershipType";
            cmbMembershipType.Size = new Size(316, 28);
            cmbMembershipType.TabIndex = 59;
            // 
            // PopupAddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 844);
            Controls.Add(cmbMembershipType);
            Controls.Add(dtpMembershipDate);
            Controls.Add(cmbGender);
            Controls.Add(cmbStatus);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(txtDescription);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(txtDob);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtNic);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopupAddMember";
            Text = "PopupAddMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGender;
        private ComboBox cmbStatus;
        private Button btnConfirm;
        private Button btnCancel;
        private RichTextBox txtDescription;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtDob;
        private Label label8;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtNic;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtFullName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpMembershipDate;
        private ComboBox cmbMembershipType;
    }
}