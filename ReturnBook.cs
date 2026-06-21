using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class ReturnBook : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public ReturnBook()
        {
            InitializeComponent();
            LoadReturnedBooks();
        }

        private void LoadReturnedBooks()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Only selects books where the status is 'Returned'
                    string query = @"SELECT book_id, member_id, issue_date, due_date, return_date, 
                                            fine_amount AS fine, status 
                                     FROM loans 
                                     WHERE status = 'Returned' 
                                     ORDER BY return_date DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Link this to your "Return Book" button above the table
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            PopupReturnBook returnForm = new PopupReturnBook();
            returnForm.ShowDialog();

            // Instantly refresh this table when the popup closes!
            LoadReturnedBooks();
        }
    }
}