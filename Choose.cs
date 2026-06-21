using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
            UserLogin loginForm = new UserLogin();
            loginForm.Show();
            this.Close();
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }
    }
}
