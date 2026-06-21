using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class IssueBook : Form // Make sure this matches your actual form name!
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public IssueBook()
        {
            InitializeComponent();

            // Instantly load the data the moment the page opens
            LoadIssuedBooksData();
        }

        private void LoadIssuedBooksData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // This JOIN grabs the dates from 'issued_books' (i) 
                    // and grabs the title/copies from 'books' (b)
                    string query = @"SELECT 
                                        i.issue_id, 
                                        i.book_id, 
                                        b.book_title, 
                                        b.available_copies, 
                                        i.issue_date, 
                                        i.due_date 
                                     FROM issued_books i
                                     JOIN books b ON i.book_id = b.book_id
                                     ORDER BY i.id DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Stop the grid from creating duplicate unmapped columns
                            dataGridView1.AutoGenerateColumns = false;

                            // Load the merged data into your table
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading issued books data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- ISSUE BOOK BUTTON ---
        // (Make sure to link this click event in your designer properties via the Lightning Bolt icon!)
        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            // Open your IssueBook popup form
            PopupIssueBook issueForm = new PopupIssueBook();

            // Pauses the code until the user finishes issuing the book
            issueForm.ShowDialog();

            // The exact second the popup closes, refresh the table to show the new record and updated available copies!
            LoadIssuedBooksData();
        }
    }
}