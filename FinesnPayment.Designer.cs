namespace Library_management_system
{
    partial class Fines_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fines_Payment));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            edit = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(158, 161, 212);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1043, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(709, 99);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search book";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(158, 161, 212);
            label2.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 42);
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
            label1.Location = new Point(12, 2);
            label1.Name = "label1";
            label1.Size = new Size(267, 40);
            label1.TabIndex = 5;
            label1.Text = "Fines and Payments";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(158, 161, 212);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1096, 145);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column8, Column1, Column2, Column3, Column4, Column5, Column6, Column7, edit });
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(0, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1096, 538);
            dataGridView1.TabIndex = 11;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.DataPropertyName = "fine_id";
            Column8.HeaderText = "Fine ID";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 84;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.DataPropertyName = "member_id";
            Column1.HeaderText = "Member ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 104;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "book_id";
            Column2.HeaderText = "Book ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "due_date";
            Column3.HeaderText = "Due date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "return_date";
            Column4.HeaderText = "Returned date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "days_late";
            Column5.HeaderText = "Days late";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "fine_amount";
            Column6.HeaderText = "Fine amount";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "fine_status";
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            edit.HeaderText = "";
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.Width = 24;
            // 
            // Fines_Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 679);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fines_Payment";
            Text = "Fines_Payment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn Column7;
        private DataGridViewImageColumn edit;
    }
}