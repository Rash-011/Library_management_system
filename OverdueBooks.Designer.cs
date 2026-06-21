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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1043, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(709, 106);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search book";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 90);
            button1.Name = "button1";
            button1.Size = new Size(205, 43);
            button1.TabIndex = 7;
            button1.Text = "Add New Book";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
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
            label1.Font = new Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 40);
            label1.TabIndex = 5;
            label1.Text = "Manage Books";
            // 
            // panel1
            // 
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
            book_id.DataPropertyName = "book_id";
            book_id.HeaderText = "Loan ID";
            book_id.MinimumWidth = 6;
            book_id.Name = "book_id";
            book_id.Width = 89;
            // 
            // language
            // 
            language.DataPropertyName = "language";
            language.HeaderText = "Member ID";
            language.MinimumWidth = 6;
            language.Name = "language";
            // 
            // isbn
            // 
            isbn.DataPropertyName = "isbn";
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
            author_name.DataPropertyName = "author_name";
            author_name.HeaderText = "Due date";
            author_name.MinimumWidth = 6;
            author_name.Name = "author_name";
            // 
            // Column1
            // 
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
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OverdueBooks";
            Text = "OverdueBooks";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
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