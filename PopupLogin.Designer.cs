namespace Library_management_system
{
    partial class PopupLogin
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 33);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // button1
            // 
            button1.Location = new Point(166, 140);
            button1.Name = "button1";
            button1.Size = new Size(129, 35);
            button1.TabIndex = 1;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(166, 202);
            button2.Name = "button2";
            button2.Size = new Size(129, 35);
            button2.TabIndex = 2;
            button2.Text = "User";
            button2.UseVisualStyleBackColor = true;
            // 
            // PopupLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopupLogin";
            Text = "PopupLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}