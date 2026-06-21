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
            panel2 = new Panel();
            btnReport = new Button();
            btnFines = new Button();
            btnActiveLoan = new Button();
            btnOverdue = new Button();
            btnIssueBook = new Button();
            btnBooks = new Button();
            btnMembers = new Button();
            btnDashboard = new Button();
            mainpanel = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 89);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 70, 102);
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
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(42, 70, 102);
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(17, 434);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(286, 46);
            btnReport.TabIndex = 7;
            btnReport.Text = "Overdue Books";
            btnReport.UseVisualStyleBackColor = false;
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
            btnFines.Location = new Point(17, 538);
            btnFines.Name = "btnFines";
            btnFines.Size = new Size(313, 46);
            btnFines.TabIndex = 6;
            btnFines.Text = "Fines and Payment";
            btnFines.UseVisualStyleBackColor = false;
            btnFines.Click += btnFines_Click;
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
            btnActiveLoan.Location = new Point(17, 486);
            btnActiveLoan.Name = "btnActiveLoan";
            btnActiveLoan.Size = new Size(260, 46);
            btnActiveLoan.TabIndex = 5;
            btnActiveLoan.Text = "Active Loans";
            btnActiveLoan.UseVisualStyleBackColor = false;
            btnActiveLoan.Click += btnActiveLoan_Click;
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
            btnOverdue.Location = new Point(17, 382);
            btnOverdue.Name = "btnOverdue";
            btnOverdue.Size = new Size(266, 46);
            btnOverdue.TabIndex = 4;
            btnOverdue.Text = "Return Books";
            btnOverdue.UseVisualStyleBackColor = false;
            btnOverdue.Click += btnOverdue_Click;
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
            btnIssueBook.Location = new Point(17, 330);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(253, 46);
            btnIssueBook.TabIndex = 3;
            btnIssueBook.Text = "Issue Books";
            btnIssueBook.UseVisualStyleBackColor = false;
            btnIssueBook.Click += btnIssueBook_Click_1;
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
            btnBooks.Location = new Point(17, 278);
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
            btnMembers.Location = new Point(17, 226);
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
            btnDashboard.Location = new Point(17, 174);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(253, 46);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 70, 102);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(17, 590);
            button1.Name = "button1";
            button1.Size = new Size(306, 46);
            button1.TabIndex = 8;
            button1.Text = "Reports / Settings";
            button1.UseVisualStyleBackColor = false;
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
    }
}
