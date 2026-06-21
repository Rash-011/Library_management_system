namespace Library_management_system
{
    partial class ManageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooks));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            book_id = new DataGridViewTextBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            book_title = new DataGridViewTextBoxColumn();
            author_name = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            language = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            btnView = new DataGridViewImageColumn();
            btnUpdate = new DataGridViewImageColumn();
            btnDelete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 145);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1043, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(709, 97);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search book";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 81);
            button1.Name = "button1";
            button1.Size = new Size(205, 43);
            button1.TabIndex = 2;
            button1.Text = "Add New Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(292, 18);
            label2.TabIndex = 1;
            label2.Text = "Add, edit or remove books from catelog.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Books";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { book_id, isbn, book_title, author_name, category, language, status, btnView, btnUpdate, btnDelete });
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(0, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1096, 538);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // book_id
            // 
            book_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            book_id.DataPropertyName = "book_id";
            book_id.HeaderText = "Book ID";
            book_id.MinimumWidth = 6;
            book_id.Name = "book_id";
            book_id.Width = 91;
            // 
            // isbn
            // 
            isbn.DataPropertyName = "isbn";
            isbn.HeaderText = "ISBN";
            isbn.MinimumWidth = 6;
            isbn.Name = "isbn";
            // 
            // book_title
            // 
            book_title.DataPropertyName = "book_title";
            book_title.HeaderText = "Title";
            book_title.MinimumWidth = 6;
            book_title.Name = "book_title";
            // 
            // author_name
            // 
            author_name.DataPropertyName = "author_name";
            author_name.HeaderText = "Author";
            author_name.MinimumWidth = 6;
            author_name.Name = "author_name";
            // 
            // category
            // 
            category.DataPropertyName = "category";
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            // 
            // language
            // 
            language.DataPropertyName = "language";
            language.HeaderText = "Language";
            language.MinimumWidth = 6;
            language.Name = "language";
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
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
            // btnUpdate
            // 
            btnUpdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btnUpdate.HeaderText = "";
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.MinimumWidth = 6;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Width = 24;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btnDelete.HeaderText = "";
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.Width = 24;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 679);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageBooks";
            Text = "ManageBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn isbn;
        private DataGridViewTextBoxColumn book_title;
        private DataGridViewTextBoxColumn author_name;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn language;
        private DataGridViewTextBoxColumn status;
        private DataGridViewImageColumn btnView;
        private DataGridViewImageColumn btnUpdate;
        private DataGridViewImageColumn btnDelete;
    }
}
