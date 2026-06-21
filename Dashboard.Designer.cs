namespace Library_management_system
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnFines = new Button();
            btnOverdue = new Button();
            btnReport = new Button();
            button1 = new Button();
            btnIssueBook = new Button();
            btnActiveLoan = new Button();
            btnBooks = new Button();
            btnMembers = new Button();
            btnDashboard = new Button();
            mainpanel = new Panel();
            btnLogOut = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 89);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1207, 49);
            label4.Name = "label4";
            label4.Size = new Size(113, 18);
            label4.TabIndex = 3;
            label4.Text = "Rasika Prabath";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Semi Bold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1207, 20);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 1;
            label2.Text = "Admin\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1141, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Semi Bold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(111, 35);
            label1.Name = "label1";
            label1.Size = new Size(259, 22);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 70, 102);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnFines);
            panel2.Controls.Add(btnOverdue);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnIssueBook);
            panel2.Controls.Add(btnActiveLoan);
            panel2.Controls.Add(btnBooks);
            panel2.Controls.Add(btnMembers);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 679);
            panel2.TabIndex = 1;
            // 
            // btnFines
            // 
            btnFines.BackColor = Color.FromArgb(42, 70, 102);
            btnFines.FlatAppearance.BorderSize = 0;
            btnFines.FlatStyle = FlatStyle.Flat;
            btnFines.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFines.ForeColor = Color.White;
            btnFines.Image = (Image)resources.GetObject("btnFines.Image");
            btnFines.ImageAlign = ContentAlignment.MiddleLeft;
            btnFines.Location = new Point(17, 431);
            btnFines.Name = "btnFines";
            btnFines.Size = new Size(313, 46);
            btnFines.TabIndex = 6;
            btnFines.Text = "Fines and Payment";
            btnFines.UseVisualStyleBackColor = false;
            btnFines.Click += btnFines_Click;
            // 
            // btnOverdue
            // 
            btnOverdue.BackColor = Color.FromArgb(42, 70, 102);
            btnOverdue.FlatAppearance.BorderSize = 0;
            btnOverdue.FlatStyle = FlatStyle.Flat;
            btnOverdue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOverdue.ForeColor = Color.White;
            btnOverdue.Image = (Image)resources.GetObject("btnOverdue.Image");
            btnOverdue.ImageAlign = ContentAlignment.MiddleLeft;
            btnOverdue.Location = new Point(17, 275);
            btnOverdue.Name = "btnOverdue";
            btnOverdue.Size = new Size(266, 46);
            btnOverdue.TabIndex = 4;
            btnOverdue.Text = "Return Books";
            btnOverdue.UseVisualStyleBackColor = false;
            btnOverdue.Click += btnOverdue_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(42, 70, 102);
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(17, 327);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(286, 46);
            btnReport.TabIndex = 7;
            btnReport.Text = "Overdue Books";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 70, 102);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(17, 483);
            button1.Name = "button1";
            button1.Size = new Size(306, 46);
            button1.TabIndex = 8;
            button1.Text = "Account Settings";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnIssueBook
            // 
            btnIssueBook.BackColor = Color.FromArgb(42, 70, 102);
            btnIssueBook.FlatAppearance.BorderSize = 0;
            btnIssueBook.FlatStyle = FlatStyle.Flat;
            btnIssueBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIssueBook.ForeColor = Color.White;
            btnIssueBook.Image = (Image)resources.GetObject("btnIssueBook.Image");
            btnIssueBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnIssueBook.Location = new Point(17, 223);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(253, 46);
            btnIssueBook.TabIndex = 3;
            btnIssueBook.Text = "Issue Books";
            btnIssueBook.UseVisualStyleBackColor = false;
            btnIssueBook.Click += btnIssueBook_Click_1;
            // 
            // btnActiveLoan
            // 
            btnActiveLoan.BackColor = Color.FromArgb(42, 70, 102);
            btnActiveLoan.FlatAppearance.BorderSize = 0;
            btnActiveLoan.FlatStyle = FlatStyle.Flat;
            btnActiveLoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActiveLoan.ForeColor = Color.White;
            btnActiveLoan.Image = (Image)resources.GetObject("btnActiveLoan.Image");
            btnActiveLoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveLoan.Location = new Point(17, 379);
            btnActiveLoan.Name = "btnActiveLoan";
            btnActiveLoan.Size = new Size(260, 46);
            btnActiveLoan.TabIndex = 5;
            btnActiveLoan.Text = "Active Loans";
            btnActiveLoan.UseVisualStyleBackColor = false;
            btnActiveLoan.Click += btnActiveLoan_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.FromArgb(42, 70, 102);
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = Color.White;
            btnBooks.Image = (Image)resources.GetObject("btnBooks.Image");
            btnBooks.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooks.Location = new Point(17, 171);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(278, 46);
            btnBooks.TabIndex = 2;
            btnBooks.Text = "Manage Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click_1;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.FromArgb(42, 70, 102);
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMembers.ForeColor = Color.White;
            btnMembers.Image = (Image)resources.GetObject("btnMembers.Image");
            btnMembers.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembers.Location = new Point(17, 119);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(306, 46);
            btnMembers.TabIndex = 1;
            btnMembers.Text = "Manage Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(42, 70, 102);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(17, 67);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(253, 46);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(242, 250, 255);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(270, 89);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1096, 679);
            mainpanel.TabIndex = 3;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(42, 70, 102);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ControlLight;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(17, 614);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(227, 53);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(mainpanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel mainpanel;
        private Button btnDashboard;
        private Button btnReport;
        private Button btnFines;
        private Button btnActiveLoan;
        private Button btnOverdue;
        private Button btnIssueBook;
        private Button btnBooks;
        private Button btnMembers;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label4;
        private Button btnLogOut;
    }
}
