using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class MyBooksForm : Form
    {
        string connString = "server=localhost; database=library_db; uid=root; pwd=;";
        public MyBooksForm()
        {
            InitializeComponent();
        }

        private void MyBooksForm_Load(object sender, EventArgs e)
        {
           
            LoadMyBorrowedBooks(UserSession.MemberId.ToString());
        }
        public void LoadMyBorrowedBooks(string memberId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Query to fetch borrowed book details
                    string query = @"SELECT b.book_title, b.author_name, l.issue_date, l.due_date, l.status,
                                   CASE 
                                    WHEN l.status = 'Returned' THEN 'Completed'
                                    WHEN l.due_date < CURRENT_DATE THEN 'Overdue'
                                    WHEN l.due_date BETWEEN CURRENT_DATE AND DATE_ADD(CURRENT_DATE, INTERVAL 2 DAY) THEN 'Due Soon'
                                    ELSE 'Normal'
                                   END AS description
                                     FROM loans l 
                                     JOIN books b ON l.book_id = b.book_id 
                                     WHERE l.member_id = @memberId";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@memberId", memberId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMyBooks.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvMyBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvMyBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvMyBooks.Columns[e.ColumnIndex].Name == "description")
            {
                if (e.Value != null && e.Value.ToString() == "Overdue")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }
                else if (e.Value != null && e.Value.ToString() == "Due Soon")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
