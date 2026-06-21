namespace Library_management_system
{
    partial class PopupIssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupIssueBook));
            btnConfirm = new Button();
            button1 = new Button();
            txtDescription = new RichTextBox();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpIssueDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            txtSearchMember = new TextBox();
            txtSearchBook = new TextBox();
            btnSearchBook = new PictureBox();
            btnSearchMember = new PictureBox();
            txtMemberStatus = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnSearchBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchMember).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(187, 720);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(141, 48);
            btnConfirm.TabIndex = 45;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 720);
            button1.Name = "button1";
            button1.Size = new Size(141, 48);
            button1.TabIndex = 44;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 537);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(348, 120);
            txtDescription.TabIndex = 43;
            txtDescription.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 512);
            label9.Name = "label9";
            label9.Size = new Size(180, 22);
            label9.TabIndex = 42;
            label9.Text = "Description (optional)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 426);
            label6.Name = "label6";
            label6.Size = new Size(86, 22);
            label6.TabIndex = 36;
            label6.Text = "Due Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 341);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 34;
            label5.Text = "Issue Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(255, 22);
            label4.TabIndex = 32;
            label4.Text = "Search member by ID or Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(230, 22);
            label3.TabIndex = 30;
            label3.Text = "Search book by ID or Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(436, 18);
            label2.TabIndex = 29;
            label2.Text = "Fill in the details below to add the new book to the database.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Semi Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 28;
            label1.Text = "Issue Book";
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Location = new Point(12, 366);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(348, 27);
            dtpIssueDate.TabIndex = 48;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(12, 451);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(348, 27);
            dtpDueDate.TabIndex = 49;
            // 
            // txtSearchMember
            // 
            txtSearchMember.Location = new Point(12, 190);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.Size = new Size(316, 27);
            txtSearchMember.TabIndex = 50;
            // 
            // txtSearchBook
            // 
            txtSearchBook.Location = new Point(12, 111);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.Size = new Size(316, 27);
            txtSearchBook.TabIndex = 51;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Cursor = Cursors.Hand;
            btnSearchBook.Image = (Image)resources.GetObject("btnSearchBook.Image");
            btnSearchBook.Location = new Point(334, 112);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(26, 26);
            btnSearchBook.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSearchBook.TabIndex = 52;
            btnSearchBook.TabStop = false;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // btnSearchMember
            // 
            btnSearchMember.Cursor = Cursors.Hand;
            btnSearchMember.Image = (Image)resources.GetObject("btnSearchMember.Image");
            btnSearchMember.Location = new Point(334, 191);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new Size(26, 26);
            btnSearchMember.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSearchMember.TabIndex = 53;
            btnSearchMember.TabStop = false;
            btnSearchMember.Click += btnSearchMember_Click;
            // 
            // txtMemberStatus
            // 
            txtMemberStatus.Location = new Point(12, 283);
            txtMemberStatus.Name = "txtMemberStatus";
            txtMemberStatus.Size = new Size(348, 27);
            txtMemberStatus.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 258);
            label7.Name = "label7";
            label7.Size = new Size(61, 22);
            label7.TabIndex = 54;
            label7.Text = "Status\r\n";
            // 
            // PopupIssueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 780);
            Controls.Add(txtMemberStatus);
            Controls.Add(label7);
            Controls.Add(btnSearchMember);
            Controls.Add(btnSearchBook);
            Controls.Add(txtSearchBook);
            Controls.Add(txtSearchMember);
            Controls.Add(dtpDueDate);
            Controls.Add(dtpIssueDate);
            Controls.Add(btnConfirm);
            Controls.Add(button1);
            Controls.Add(txtDescription);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopupIssueBook";
            Text = "PopupIssueBook";
            ((System.ComponentModel.ISupportInitialize)btnSearchBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Button button1;
        private RichTextBox txtDescription;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpIssueDate;
        private DateTimePicker dtpDueDate;
        private TextBox txtSearchMember;
        private TextBox txtSearchBook;
        private PictureBox btnSearchBook;
        private PictureBox btnSearchMember;
        private TextBox txtMemberStatus;
        private Label label7;
    }
}