using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class HomeSummaryForm : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public HomeSummaryForm()
        {
            InitializeComponent();

            // Instantly fetch the live numbers when the dashboard loads!
            LoadDashboardMetrics();
        }

        private void LoadDashboardMetrics()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // --- 1. TOTAL BOOKS ---
                    // Counts every single row in your books table
                    string queryBooks = "SELECT COUNT(*) FROM books";
                    using (MySqlCommand cmd = new MySqlCommand(queryBooks, conn))
                    {
                        lblTotalBooks.Text = cmd.ExecuteScalar().ToString();
                    }

                    // --- 2. TOTAL MEMBERS ---
                    // Counts all members
                    string queryMembers = "SELECT COUNT(*) FROM members";
                    using (MySqlCommand cmd = new MySqlCommand(queryMembers, conn))
                    {
                        lblTotalMembers.Text = cmd.ExecuteScalar().ToString();
                    }

                    // --- 3. ACTIVE LOANS ---
                    // Only counts loans where the status is 'Active'
                    string queryActiveLoans = "SELECT COUNT(*) FROM loans WHERE status = 'Active'";
                    using (MySqlCommand cmd = new MySqlCommand(queryActiveLoans, conn))
                    {
                        lblActiveLoans.Text = cmd.ExecuteScalar().ToString();
                    }

                    // --- 4. OVERDUE BOOKS ---
                    // Counts active loans that have passed today's date
                    string queryOverdue = "SELECT COUNT(*) FROM loans WHERE status = 'Active' AND due_date < CURRENT_DATE";
                    using (MySqlCommand cmd = new MySqlCommand(queryOverdue, conn))
                    {
                        lblOverdueBooks.Text = cmd.ExecuteScalar().ToString();
                    }

                    // --- 5. UNPAID FINES ---
                    // SUMs the fine_amount column. 
                    // We use COALESCE/IFNULL in SQL just in case the table is completely empty, so it returns 0 instead of crashing.
                    string queryFines = "SELECT COALESCE(SUM(fine_amount), 0) FROM fines WHERE status = 'Unpaid'";
                    using (MySqlCommand cmd = new MySqlCommand(queryFines, conn))
                    {
                        // Formats it neatly with "Rs." 
                        lblUnpaidFines.Text = "Rs. " + cmd.ExecuteScalar().ToString();
                    }

                    // --- 6. THE MYSTERY 6TH CARD (Returned Books) ---
                    // Assuming you change the title to "Returned Books"

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
