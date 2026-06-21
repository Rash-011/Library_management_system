using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class ManageBooks : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public ManageBooks()
        {
            InitializeComponent();
            LoadBooksData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupAddBooks popup = new PopupAddBooks();
            popup.ShowDialog();
            LoadBooksData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadBooksData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT book_id, isbn, book_title, author_name, category, language, status FROM books ORDER BY book_id DESC";

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
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked a real row and not the table header
            if (e.RowIndex >= 0)
            {
                // Grab the specific Book ID from the row that was clicked
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells["book_id"].Value;
                if (cellValue == null || cellValue == DBNull.Value)
                {
                    MessageBox.Show("Error: Book ID cannot be retrieved from the selected row.", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string selectedBookId = cellValue.ToString();

                // Figure out the exact name of the column the user clicked
                string clickedColumn = dataGridView1.Columns[e.ColumnIndex].Name;

                // --- BUTTON 1: VIEW BOOK INFO ---
                if (clickedColumn == "btnView")
                {
                    // 1. Create the View form and pass the specific Book ID to it
                    ViewBookForm viewForm = new ViewBookForm(selectedBookId);

                    // 2. Open it as a popup!
                    viewForm.ShowDialog();

                    // (Note: We do not need to call LoadBooksData() here because 
                    // viewing a book doesn't change any data in the database!)
                    MessageBox.Show($"Viewing Book ID: {selectedBookId}", "View Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: Implement ViewBookForm to display full book details
                }

                // --- BUTTON 2: UPDATE BOOK ---
                else if (clickedColumn == "btnUpdate")
                {
                    try
                    {
                        UpdateBookForm updateForm = new UpdateBookForm(selectedBookId);
                        updateForm.ShowDialog();
                        LoadBooksData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening update form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // --- BUTTON 3: DELETE BOOK ---
                else if (clickedColumn == "btnDelete")
                {
                    DialogResult dialogResult = MessageBox.Show(
                        $"Are you sure you want to permanently delete book {selectedBookId}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        DeleteBook(selectedBookId);
                    }
                }
            }
        }

        private void DeleteBook(string bookId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM books WHERE book_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", bookId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooksData();
                        }
                        else
                        {
                            MessageBox.Show("No book found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
