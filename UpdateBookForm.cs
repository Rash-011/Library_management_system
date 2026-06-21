using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class UpdateBookForm : Form
    {
        // 1. We create a variable to hold the specific ID of the book we are editing
        private string targetBookId;
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        // 2. We change the constructor to accept the bookId from the main screen
        public UpdateBookForm(string bookId)
        {
            InitializeComponent();
            this.targetBookId = bookId; // Save the ID

            // 3. Immediately load the book's existing data into the textboxes
            LoadExistingBookData();
        }

        private void LoadExistingBookData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Grab everything (*) for this specific book
                    string query = "SELECT * FROM books WHERE book_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", targetBookId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If the book is found
                            {
                                // Fill the textboxes with the database information
                                txtBookTitle.Text = reader["book_title"].ToString();
                                cmbCategory.Text = reader["category"].ToString();
                                txtIsbn.Text = reader["isbn"].ToString();
                                txtLanguage.Text = reader["language"].ToString();
                                txtAuthorName.Text = reader["author_name"].ToString();
                                txtAvailableCopies.Text = reader["available_copies"].ToString();
                                txtPublisher.Text = reader["publisher"].ToString();
                                cmbStatus.Text = reader["status"].ToString();
                                txtPubYear.Text = reader["publication_year"].ToString();
                                txtDescription.Text = reader["description"].ToString();
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

        // 4. Double-click your "Update Book" button in the visual designer to create this event, then paste the code inside:
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Tell MySQL to UPDATE the specific row, not insert a new one
                    string updateQuery = @"UPDATE books SET 
                                            book_title = @title, 
                                            category = @category, 
                                            isbn = @isbn, 
                                            language = @language, 
                                            author_name = @author, 
                                            available_copies = @copies, 
                                            publisher = @publisher, 
                                            status = @status, 
                                            publication_year = @year, 
                                            description = @description 
                                           WHERE book_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txtBookTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@isbn", txtIsbn.Text.Trim());
                        cmd.Parameters.AddWithValue("@language", txtLanguage.Text.Trim());
                        cmd.Parameters.AddWithValue("@author", txtAuthorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@copies", int.TryParse(txtAvailableCopies.Text, out int copies) ? copies : 1);
                        cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@year", int.TryParse(txtPubYear.Text, out int year) ? year : DateTime.Now.Year);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());

                        // Crucial: Tell the database WHICH book to update
                        cmd.Parameters.AddWithValue("@id", targetBookId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Close the popup so the main table knows to refresh
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without saving changes
        }
    }
}
