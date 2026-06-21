namespace Library_management_system
{
    partial class UpdateBookForm
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
            cmbCategory = new ComboBox();
            cmbStatus = new ComboBox();
            btnUpdateBook = new Button();
            button1 = new Button();
            txtDescription = new RichTextBox();
            label9 = new Label();
            label10 = new Label();
            txtAvailableCopies = new TextBox();
            label11 = new Label();
            txtLanguage = new TextBox();
            label12 = new Label();
            label14 = new Label();
            txtPubYear = new TextBox();
            label8 = new Label();
            txtPublisher = new TextBox();
            label7 = new Label();
            txtAuthorName = new TextBox();
            label6 = new Label();
            txtIsbn = new TextBox();
            label4 = new Label();
            txtBookTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fiction", "", "Non-Fiction", "", "Science Fiction", "", "Fantasy", "", "Mystery", "", "Romance", "", "Thriller", "", "Historical Fiction", "", "Biography", "", "Other" });
            cmbCategory.Location = new Point(390, 125);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(316, 28);
            cmbCategory.TabIndex = 53;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "UnAvailable" });
            cmbStatus.Location = new Point(390, 371);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(316, 28);
            cmbStatus.TabIndex = 52;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(194, 773);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(141, 48);
            btnUpdateBook.TabIndex = 51;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // button1
            // 
            button1.Location = new Point(19, 773);
            button1.Name = "button1";
            button1.Size = new Size(141, 48);
            button1.TabIndex = 50;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(19, 542);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(316, 120);
            txtDescription.TabIndex = 49;
            txtDescription.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 517);
            label9.Name = "label9";
            label9.Size = new Size(180, 22);
            label9.TabIndex = 48;
            label9.Text = "Description (optional)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(390, 346);
            label10.Name = "label10";
            label10.Size = new Size(61, 22);
            label10.TabIndex = 47;
            label10.Text = "Status";
            // 
            // txtAvailableCopies
            // 
            txtAvailableCopies.Location = new Point(390, 289);
            txtAvailableCopies.Name = "txtAvailableCopies";
            txtAvailableCopies.Size = new Size(316, 27);
            txtAvailableCopies.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(390, 264);
            label11.Name = "label11";
            label11.Size = new Size(144, 22);
            label11.TabIndex = 45;
            label11.Text = "Available Copies";
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(390, 204);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(316, 27);
            txtLanguage.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(390, 179);
            label12.Name = "label12";
            label12.Size = new Size(90, 22);
            label12.TabIndex = 43;
            label12.Text = "Language";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(390, 100);
            label14.Name = "label14";
            label14.Size = new Size(177, 22);
            label14.TabIndex = 42;
            label14.Text = "Main category/Genre";
            // 
            // txtPubYear
            // 
            txtPubYear.Location = new Point(19, 456);
            txtPubYear.Name = "txtPubYear";
            txtPubYear.Size = new Size(316, 27);
            txtPubYear.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 431);
            label8.Name = "label8";
            label8.Size = new Size(141, 22);
            label8.TabIndex = 40;
            label8.Text = "Publication Year";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(19, 371);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(316, 27);
            txtPublisher.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 346);
            label7.Name = "label7";
            label7.Size = new Size(85, 22);
            label7.TabIndex = 38;
            label7.Text = "Publisher";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(19, 289);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(316, 27);
            txtAuthorName.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 264);
            label6.Name = "label6";
            label6.Size = new Size(115, 22);
            label6.TabIndex = 36;
            label6.Text = "Author Name";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(19, 204);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(316, 27);
            txtIsbn.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 179);
            label4.Name = "label4";
            label4.Size = new Size(51, 22);
            label4.TabIndex = 34;
            label4.Text = "ISBN";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(19, 125);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(316, 27);
            txtBookTitle.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 100);
            label3.Name = "label3";
            label3.Size = new Size(91, 22);
            label3.TabIndex = 32;
            label3.Text = "Book Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 47);
            label2.Name = "label2";
            label2.Size = new Size(436, 18);
            label2.TabIndex = 31;
            label2.Text = "Fill in the details below to add the new book to the database.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Semi Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(205, 24);
            label1.TabIndex = 30;
            label1.Text = "Update Book Details";
            // 
            // UpdateBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 844);
            Controls.Add(cmbCategory);
            Controls.Add(cmbStatus);
            Controls.Add(btnUpdateBook);
            Controls.Add(button1);
            Controls.Add(txtDescription);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtAvailableCopies);
            Controls.Add(label11);
            Controls.Add(txtLanguage);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(txtPubYear);
            Controls.Add(label8);
            Controls.Add(txtPublisher);
            Controls.Add(label7);
            Controls.Add(txtAuthorName);
            Controls.Add(label6);
            Controls.Add(txtIsbn);
            Controls.Add(label4);
            Controls.Add(txtBookTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateBookForm";
            Text = "UpdateBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategory;
        private ComboBox cmbStatus;
        private Button btnUpdateBook;
        private Button button1;
        private RichTextBox txtDescription;
        private Label label9;
        private Label label10;
        private TextBox txtAvailableCopies;
        private Label label11;
        private TextBox txtLanguage;
        private Label label12;
        private Label label14;
        private TextBox txtPubYear;
        private Label label8;
        private TextBox txtPublisher;
        private Label label7;
        private TextBox txtAuthorName;
        private Label label6;
        private TextBox txtIsbn;
        private Label label4;
        private TextBox txtBookTitle;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}