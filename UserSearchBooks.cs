using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_management_system
{
    public partial class UserSearchBooks : Form
    {
        string connString = "server=localhost; database=library_db; uid=root; pwd=;";
        public UserSearchBooks()
        {
            InitializeComponent();
        }

        private void UserSearchBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Create a new connection
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open(); // Open connection to the database

                    // SQL query to filter books by title or author
                    string query = "SELECT book_id, book_title, author_name, isbn, category, status FROM books WHERE book_title LIKE @keyword OR author_name LIKE @keyword";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    // Using parameters prevents SQL injection
                    adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + txtSearch.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // Fill data into the datatable

                    // Bind data to the DataGridView
                    dgvBooks.DataSource = dt;

                    // Optional: show a message if no results found
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No books found matching your search.");
                    }
                }
                catch (Exception ex)
                {
                    // Catch and display any errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
