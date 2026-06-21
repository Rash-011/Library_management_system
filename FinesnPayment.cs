using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class Fines_Payment : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public Fines_Payment()
        {
            InitializeComponent();
            LoadFinesData();
        }

        private void LoadFinesData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Joins the fines and loans tables together to get the full picture
                    string query = @"SELECT 
                                        f.fine_id,
                                        l.member_id, 
                                        l.book_id, 
                                        l.due_date, 
                                        l.return_date, 
                                        f.days_late, 
                                        f.fine_amount, 
                                        f.status AS fine_status
                                     FROM fines f
                                     JOIN loans l ON f.loan_id = l.loan_id
                                     ORDER BY f.created_at DESC";

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
    }
}