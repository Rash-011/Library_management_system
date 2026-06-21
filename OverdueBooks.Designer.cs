namespace Library_management_system
{
    partial class OverdueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverdueBooks));
            btnSearch = new PictureBox();
            txtSearchBook = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            book_id = new DataGridViewTextBoxColumn();
            language = new DataGridViewTextBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            book_title = new DataGridViewTextBoxColumn();
            author_name = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewButtonColumn();
            btnView = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(158, 161, 212);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(1043, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(26, 26);
            btnSearch.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSearch.TabIndex = 9;
            btnSearch.TabStop = false;
            // 
            // txtSearchBook
            // 
            txtSearchBook.Location = new Point(709, 106);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.PlaceholderText = "Search book";
            txtSearchBook.Size = new Size(328, 27);
            txtSearchBook.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(158, 161, 212);
            label2.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(292, 18);
            label2.TabIndex = 6;
            label2.Text = "Add, edit or remove books from catelog.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(158, 161, 212);
            label1.Font = new Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 40);
            label1.TabIndex = 5;
            label1.Text = "Overdue Books";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(158, 161, 212);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 145);
            panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { book_id, language, isbn, book_title, author_name, Column1, btnView });
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(0, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1096, 538);
            dataGridView1.TabIndex = 11;
            // 
            // book_id
            // 
            book_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            book_id.DataPropertyName = "loan_id";
            book_id.HeaderText = "Loan ID";
            book_id.MinimumWidth = 6;
            book_id.Name = "book_id";
            book_id.Width = 89;
            // 
            // language
            // 
            language.DataPropertyName = "member_id";
            language.HeaderText = "Member ID";
            language.MinimumWidth = 6;
            language.Name = "language";
            // 
            // isbn
            // 
            isbn.DataPropertyName = "full_name";
            isbn.HeaderText = "Member Name";
            isbn.MinimumWidth = 6;
            isbn.Name = "isbn";
            // 
            // book_title
            // 
            book_title.DataPropertyName = "book_title";
            book_title.HeaderText = "Book Title";
            book_title.MinimumWidth = 6;
            book_title.Name = "book_title";
            // 
            // author_name
            // 
            author_name.DataPropertyName = "due_date";
            author_name.HeaderText = "Due date";
            author_name.MinimumWidth = 6;
            author_name.Name = "author_name";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "overdue_status";
            Column1.HeaderText = "Status";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // btnView
            // 
            btnView.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btnView.HeaderText = "";
            btnView.Image = (Image)resources.GetObject("btnView.Image");
            btnView.MinimumWidth = 6;
            btnView.Name = "btnView";
            btnView.Width = 24;
            // 
            // OverdueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 679);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OverdueBooks";
            Text = "OverdueBooks";
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnSearch;
        private TextBox txtSearchBook;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn language;
        private DataGridViewTextBoxColumn isbn;
        private DataGridViewTextBoxColumn book_title;
        private DataGridViewTextBoxColumn author_name;
        private DataGridViewButtonColumn Column1;
        private DataGridViewImageColumn btnView;
    }
}