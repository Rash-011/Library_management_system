using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class OverdueBooks : Form // Ensure this matches your form name
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public OverdueBooks()
        {
            InitializeComponent();

            // Instantly load the overdue books the moment the page opens
            LoadOverdueBooks();
        }

        private void LoadOverdueBooks(string searchTerm = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // This query joins 3 tables AND filters for dates strictly in the past!
                    string query = @"SELECT 
                                        l.loan_id, 
                                        l.member_id, 
                                        m.full_name, 
                                        b.book_title, 
                                        l.due_date, 
                                        'Overdue' AS overdue_status
                                     FROM loans l
                                     JOIN members m ON l.member_id = m.member_id
                                     JOIN books b ON l.book_id = b.book_id
                                     WHERE l.status = 'Active' 
                                     AND l.due_date < CURRENT_DATE ";

                    // If the user typed something in the search box, add this to the query
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += "AND (l.loan_id LIKE @search OR m.member_id LIKE @search OR b.book_title LIKE @search OR m.full_name LIKE @search) ";
                    }

                    // Order by the oldest due date first
                    query += "ORDER BY l.due_date ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                        }

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
                    MessageBox.Show($"Error loading overdue books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- SEARCH BUTTON LOGIC ---
        // Double-click your magnifying glass icon to generate this event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBook.Text.Trim(); // Make sure this matches your search textbox name
            LoadOverdueBooks(searchTerm);
        }

        // Optional: If you want it to refresh automatically when the user clears the search box
        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBook.Text))
            {
                LoadOverdueBooks();
            }
        }
    }
}
