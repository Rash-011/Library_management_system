using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class ViewBookForm : Form
    {
        private string targetBookId;
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        // Change the constructor to accept the ID
        public ViewBookForm(string bookId)
        {
            InitializeComponent();
            this.targetBookId = bookId;

            // Load the data the instant the form opens
            LoadBookDetails();
        }

        private void LoadBookDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Select EVERYTHING (*) for this specific book
                    string query = "SELECT * FROM books WHERE book_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", targetBookId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Fill the LABELS with the database information
                                lblBookTitle.Text = reader["book_title"].ToString();
                                lblCategory.Text = reader["category"].ToString();
                                lblIsbn.Text = reader["isbn"].ToString();
                                lblLanguage.Text = reader["language"].ToString();
                                lblAuthorName.Text = reader["author_name"].ToString();
                                lblCopies.Text = reader["available_copies"].ToString();
                                lblPublisher.Text = reader["publisher"].ToString();
                                lblStatus.Text = reader["status"].ToString();
                                lblYear.Text = reader["publication_year"].ToString();
                                lblDescription.Text = reader["description"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Could not find the details for this book.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading book data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
