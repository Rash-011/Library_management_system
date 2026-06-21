namespace Library_management_system
{
    partial class MyBooksForm
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
            dgvMyBooks = new DataGridView();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMyBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvMyBooks
            // 
            dgvMyBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyBooks.Location = new Point(29, 85);
            dgvMyBooks.Margin = new Padding(3, 2, 3, 2);
            dgvMyBooks.Name = "dgvMyBooks";
            dgvMyBooks.ReadOnly = true;
            dgvMyBooks.RowHeadersWidth = 51;
            dgvMyBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyBooks.Size = new Size(765, 262);
            dgvMyBooks.TabIndex = 1;
            dgvMyBooks.CellContentClick += dgvMyBooks_CellContentClick;
            dgvMyBooks.CellFormatting += dgvMyBooks_CellFormatting;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(42, 70, 102);
            btnBack.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(568, 362);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(170, 31);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(42, 70, 102);
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 17);
            label1.Name = "label1";
            label1.Size = new Size(247, 29);
            label1.TabIndex = 4;
            label1.Text = "My Borrowed Books";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 52);
            label2.Name = "label2";
            label2.Size = new Size(358, 18);
            label2.TabIndex = 5;
            label2.Text = "Keep track of your borrowed items and due dates. 📚";
            // 
            // MyBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 415);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgvMyBooks);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MyBooksForm";
            Text = "MyBooksForm";
            Load += MyBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvMyBooks;
        private Button btnBack;
        private Label label1;
        private Label label2;
    }
}