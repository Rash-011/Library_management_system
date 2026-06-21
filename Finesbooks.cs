using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Library_management_system
{
    public partial class Finesbooks : Form
    {
        // Simulated logged-in user ID
        private string loggedInMemberId = "05";

        // Database connection string setup 
        public static string dbConn = "server=localhost;database=library_db;uid=root;pwd=;";
        MySqlDataAdapter adapter;
        DataTable dataTable;
        public Finesbooks()
        {
            InitializeComponent();
        }

        private void Finesbooks_Load(object sender, EventArgs e)
        {
            LoadUserFines();
        }

        private void LoadUserFines()
        {
            // SQL query to fetch all loan records belonging to the logged-in member
            string query = "SELECT loan_id, book_id, issue_date, due_date, return_date, fine_amount, fine_status, description, status FROM loans WHERE member_id = @MemberID";

            using (MySqlConnection conn = new MySqlConnection(dbConn))
            {
                try
                {
                    conn.Open();

                    // 1. Fetching and loading data into the DataGridView
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@MemberID", loggedInMemberId);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Set the DataGridView data source (make sure the control name matches 'dataGridView1')
                        dataGridView1.DataSource = dataTable;
                    }

                    // 2. Calculating Total Outstanding Fine (Only where fine_status is 'Unpaid')
                    string sumQuery = "SELECT SUM(fine_amount) FROM loans WHERE member_id = @MemberID AND fine_status = 'Unpaid'";

                    using (MySqlCommand cmd = new MySqlCommand(sumQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", loggedInMemberId);
                        object result = cmd.ExecuteScalar();

                        // If there is an unpaid balance, display it as Rs. X.XX, otherwise display Rs. 0.00
                        if (result != DBNull.Value && result != null)
                        {
                            decimal totalFine = Convert.ToDecimal(result);
                            totalfine.Text = "Rs. " + totalFine.ToString("N2");
                        }
                        else
                        {
                            totalfine.Text = "Rs. 0.00";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Displays an error message box if any database issues occur
                    MessageBox.Show("Error loading fine details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
