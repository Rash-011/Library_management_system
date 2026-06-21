namespace Library_management_system
{
    partial class PopupReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupReturnBook));
            btnSearchMember = new PictureBox();
            btnSearchBook = new PictureBox();
            txtSearchBook = new TextBox();
            txtSearchMember = new TextBox();
            btnConfirm = new Button();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblIssueDate = new Label();
            lblDueDate = new Label();
            lblFine = new Label();
            lblDaysLate = new Label();
            label13 = new Label();
            label14 = new Label();
            dtpReturnDate = new DateTimePicker();
            lblIssueId = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnSearchMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchBook).BeginInit();
            SuspendLayout();
            // 
            // btnSearchMember
            // 
            btnSearchMember.Cursor = Cursors.Hand;
            btnSearchMember.Image = (Image)resources.GetObject("btnSearchMember.Image");
            btnSearchMember.Location = new Point(334, 191);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new Size(26, 26);
            btnSearchMember.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSearchMember.TabIndex = 71;
            btnSearchMember.TabStop = false;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Cursor = Cursors.Hand;
            btnSearchBook.Image = (Image)resources.GetObject("btnSearchBook.Image");
            btnSearchBook.Location = new Point(334, 112);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(26, 26);
            btnSearchBook.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSearchBook.TabIndex = 70;
            btnSearchBook.TabStop = false;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // txtSearchBook
            // 
            txtSearchBook.Location = new Point(12, 111);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(316, 27);
            txtSearchBook.TabIndex = 69;
            // 
            // txtSearchMember
            // 
            txtSearchMember.Location = new Point(12, 190);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.Size = new Size(316, 27);
            txtSearchMember.TabIndex = 68;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(187, 720);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(141, 48);
            btnConfirm.TabIndex = 65;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 720);
            button1.Name = "button1";
            button1.Size = new Size(141, 48);
            button1.TabIndex = 64;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 287);
            label7.Name = "label7";
            label7.Size = new Size(95, 22);
            label7.TabIndex = 60;
            label7.Text = "Issue Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 380);
            label6.Name = "label6";
            label6.Size = new Size(107, 22);
            label6.TabIndex = 59;
            label6.Text = "Return Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 334);
            label5.Name = "label5";
            label5.Size = new Size(86, 22);
            label5.TabIndex = 58;
            label5.Text = "Due Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(255, 22);
            label4.TabIndex = 57;
            label4.Text = "Search member by ID or Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(230, 22);
            label3.TabIndex = 56;
            label3.Text = "Search book by ID or Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(436, 18);
            label2.TabIndex = 55;
            label2.Text = "Fill in the details below to add the new book to the database.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Semi Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 24);
            label1.TabIndex = 54;
            label1.Text = "Return Book";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIssueDate.Location = new Point(124, 287);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(55, 23);
            lblIssueDate.TabIndex = 72;
            lblIssueDate.Text = "label8";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDueDate.Location = new Point(124, 333);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 23);
            lblDueDate.TabIndex = 73;
            lblDueDate.Text = "label9";
            // 
            // lblFine
            // 
            lblFine.AutoSize = true;
            lblFine.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFine.Location = new Point(124, 497);
            lblFine.Name = "lblFine";
            lblFine.Size = new Size(59, 23);
            lblFine.TabIndex = 78;
            lblFine.Text = "lblFine";
            // 
            // lblDaysLate
            // 
            lblDaysLate.AutoSize = true;
            lblDaysLate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDaysLate.Location = new Point(124, 454);
            lblDaysLate.Name = "lblDaysLate";
            lblDaysLate.Size = new Size(64, 23);
            lblDaysLate.TabIndex = 77;
            lblDaysLate.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 498);
            label13.Name = "label13";
            label13.Size = new Size(45, 22);
            label13.TabIndex = 76;
            label13.Text = "Fine";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(12, 454);
            label14.Name = "label14";
            label14.Size = new Size(85, 22);
            label14.TabIndex = 75;
            label14.Text = "Days late";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(12, 405);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(348, 27);
            dtpReturnDate.TabIndex = 79;
            // 
            // lblIssueId
            // 
            lblIssueId.AutoSize = true;
            lblIssueId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIssueId.Location = new Point(124, 240);
            lblIssueId.Name = "lblIssueId";
            lblIssueId.Size = new Size(64, 23);
            lblIssueId.TabIndex = 81;
            lblIssueId.Text = "label10";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(12, 240);
            label15.Name = "label15";
            label15.Size = new Size(74, 22);
            label15.TabIndex = 80;
            label15.Text = "Issue ID";
            // 
            // PopupReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 780);
            Controls.Add(lblIssueId);
            Controls.Add(label15);
            Controls.Add(dtpReturnDate);
            Controls.Add(lblFine);
            Controls.Add(lblDaysLate);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(lblDueDate);
            Controls.Add(lblIssueDate);
            Controls.Add(btnSearchMember);
            Controls.Add(btnSearchBook);
            Controls.Add(txtSearchBook);
            Controls.Add(txtSearchMember);
            Controls.Add(btnConfirm);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopupReturnBook";
            Text = "PopupReturnBook";
            ((System.ComponentModel.ISupportInitialize)btnSearchMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnSearchMember;
        private PictureBox btnSearchBook;
        private TextBox txtSearchBook;
        private TextBox txtSearchMember;
        private Button btnConfirm;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblIssueDate;
        private Label lblDueDate;
        private Label lblFine;
        private Label lblDaysLate;
        private Label label13;
        private Label label14;
        private DateTimePicker dtpReturnDate;
        private Label lblIssueId;
        private Label label15;
    }
}