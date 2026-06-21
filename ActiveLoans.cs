using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class ActiveLoans : Form // Ensure this matches form name
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public ActiveLoans()
        {
            InitializeComponent();

            // Instantly load the live calculations when the page opens
            LoadActiveLoans();
        }

        private void LoadActiveLoans()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // The "Smart Query" that does the math instantly without needing nightly updates!
                    string query = @"
                        SELECT 
                            loan_id, 
                            member_id, 
                            book_id, 
                            issue_date, 
                            due_date, 
                            return_date,
                            
                            -- 1. Calculate Overdue Days (0 if not late)
                            CASE 
                                WHEN CURRENT_DATE > due_date THEN DATEDIFF(CURRENT_DATE, due_date) 
                                ELSE 0 
                            END AS no_of_due_days,
                            
                            -- 2. Calculate Fine (Rs. 20 per overdue day)
                            CASE 
                                WHEN CURRENT_DATE > due_date THEN DATEDIFF(CURRENT_DATE, due_date) * 20 
                                ELSE 0 
                            END AS fine_amount,
                            
                            -- 3. Show Fine Status automatically
                            CASE 
                                WHEN CURRENT_DATE > due_date THEN 'Unpaid' 
                                ELSE 'No Fine' 
                            END AS fine_status
                            
                        FROM loans 
                        WHERE status = 'Active' 
                        ORDER BY due_date ASC"; // Sorts so the most overdue books appear at the top!

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading active loans: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}