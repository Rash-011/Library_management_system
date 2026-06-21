using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Windows.Forms; // Remove or change if using WPF / ASP.NET
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class PopupAddBooks : Form
    {
        public PopupAddBooks()
        {
            InitializeComponent();
        }
        private void ClearFormFields()
        {
            // Clear all text boxes
            txtBookTitle.Clear();
            txtIsbn.Clear();
            txtLanguage.Clear();
            txtAuthorName.Clear();
            txtPublisher.Clear();
            txtDescription.Clear();

            // Reset numeric fields to their defaults
            txtAvailableCopies.Text = "1";
            txtPubYear.Clear();

            // Reset dropdowns so nothing is selected
            cmbCategory.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            // Optional: Set the typing cursor back to the first text box
            txtBookTitle.Focus();
        }

        private void PopupAddBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=library_db;";

            // 2. Wrap connections in 'using' blocks to ensure they close safely even if an error occurs
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // We leave out 'id' and 'book_id' because MySQL handles them automatically.
                    // We append 'SELECT LAST_INSERT_ID();' to find out what row number was just created.
                    string insertQuery = @"INSERT INTO books (book_title, category, isbn, language, author_name, 
                                                     available_copies, publisher, status, publication_year, description) 
                                   VALUES (@title, @category, @isbn, @language, @author, 
                                           @copies, @publisher, @status, @year, @description);
                                   SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        // 3. Map your UI textboxes/dropdowns to the SQL parameters safely
                        cmd.Parameters.AddWithValue("@title", txtBookTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@isbn", txtIsbn.Text.Trim());
                        cmd.Parameters.AddWithValue("@language", txtLanguage.Text.Trim());
                        cmd.Parameters.AddWithValue("@author", txtAuthorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@copies", int.TryParse(txtAvailableCopies.Text, out int copies) ? copies : 1);
                        cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString() ?? "Available");
                        cmd.Parameters.AddWithValue("@year", int.TryParse(txtPubYear.Text, out int year) ? year : DateTime.Now.Year);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());

                        // Execute the insert and capture the newly generated numeric primary key ID
                        long newRowId = Convert.ToInt64(cmd.ExecuteScalar());

                        // 4. Retrieve the custom 'book_id' (e.g. B001) that the database trigger just generated
                        string retrieveIdQuery = "SELECT book_id FROM books WHERE id = @id";
                        using (MySqlCommand fetchCmd = new MySqlCommand(retrieveIdQuery, conn))
                        {
                            fetchCmd.Parameters.AddWithValue("@id", newRowId);
                            string generatedCustomId = fetchCmd.ExecuteScalar()?.ToString();

                            // 5. Alert the user with their brand new custom Book ID
                            MessageBox.Show($"Book added successfully!\nGenerated ID: {generatedCustomId}",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optional: Call a method here to clear form fields for the next entry
                            ClearFormFields();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Catch specific database duplicate issues (like a duplicate ISBN number)
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Error: A book with this ISBN already exists.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Application Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
