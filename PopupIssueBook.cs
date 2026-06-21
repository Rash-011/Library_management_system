using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class PopupIssueBook : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        // These invisible variables hold the official IDs once a search is successful
        private string validatedBookId = "";
        private string validatedMemberId = "";

        public PopupIssueBook()
        {
            InitializeComponent();

            // Set the default dates the moment the form opens
            dtpIssueDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(14);

            // Make Member Status read-only so users can't type in it
            txtMemberStatus.ReadOnly = true;
        }

        // --- 1. SEARCH BOOK BUTTON ---
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // CHANGED: Added LIKE and changed the query to allow partial matches
                    string query = "SELECT book_id, book_title, status FROM books WHERE book_id = @term OR book_title LIKE @likeTerm LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        string searchTerm = txtSearchBook.Text.Trim();

                        // @term is for the exact ID search (e.g., B001)
                        cmd.Parameters.AddWithValue("@term", searchTerm);

                        // @likeTerm surrounds the word with % symbols so it can find partial words (e.g., %madol%)
                        cmd.Parameters.AddWithValue("@likeTerm", "%" + searchTerm + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["status"].ToString() == "Available")
                                {
                                    validatedBookId = reader["book_id"].ToString();
                                    txtSearchBook.Text = $"{validatedBookId} - {reader["book_title"].ToString()}";
                                    MessageBox.Show("Book found and is available!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("This book is already issued or unavailable.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    validatedBookId = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("No book found with that ID or Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                validatedBookId = "";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- 2. SEARCH MEMBER BUTTON ---
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // CHANGED: Added LIKE for partial name matching
                    string query = "SELECT member_id, full_name, status FROM members WHERE member_id = @term OR full_name LIKE @likeTerm LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        string searchTerm = txtSearchMember.Text.Trim();

                        cmd.Parameters.AddWithValue("@term", searchTerm);

                        // Wraps the search word in % symbols (e.g., %rasika%)
                        cmd.Parameters.AddWithValue("@likeTerm", "%" + searchTerm + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                validatedMemberId = reader["member_id"].ToString();
                                txtSearchMember.Text = $"{validatedMemberId} - {reader["full_name"].ToString()}";
                                txtMemberStatus.Text = reader["status"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No member found with that ID or Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                validatedMemberId = "";
                                txtMemberStatus.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- 3. ISSUE DATE CHANGED (Auto-Calculate 14 days) ---
        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDueDate.Value = dtpIssueDate.Value.AddDays(14);
        }

        // --- 4. CONFIRM BUTTON (Fully Upgraded Logic) ---
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // First, make sure the user actually successfully searched for a book and member
            if (string.IsNullOrEmpty(validatedBookId) || string.IsNullOrEmpty(validatedMemberId))
            {
                MessageBox.Show("Please search and confirm both a valid Book and Member before issuing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Member Status Check: If not Active, show error and CLOSE PAGE immediately
            if (txtMemberStatus.Text.Trim() != "Active")
            {
                MessageBox.Show("Cannot issue book. This member is suspended or inactive.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Book Copies Check: Ask the database exactly how many copies are left
                    int currentCopies = 0;
                    string checkBookQuery = "SELECT available_copies FROM books WHERE book_id = @bookId";

                    using (MySqlCommand cmdCheck = new MySqlCommand(checkBookQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@bookId", validatedBookId);
                        object result = cmdCheck.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            currentCopies = Convert.ToInt32(result);
                        }
                    }

                    // If copies are 0 (or less), stop the process entirely
                    if (currentCopies <= 0)
                    {
                        MessageBox.Show("Cannot issue this book. There are 0 copies available.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // --- ACTION 1: Insert into the NEW 'loans' table ---
                    string insertLoan = @"INSERT INTO loans (book_id, member_id, issue_date, due_date, description) 
                                          VALUES (@bookId, @memberId, @issueDate, @dueDate, @description)";

                    using (MySqlCommand cmdLoan = new MySqlCommand(insertLoan, conn))
                    {
                        cmdLoan.Parameters.AddWithValue("@bookId", validatedBookId);
                        cmdLoan.Parameters.AddWithValue("@memberId", validatedMemberId);
                        cmdLoan.Parameters.AddWithValue("@issueDate", dtpIssueDate.Value.Date);
                        cmdLoan.Parameters.AddWithValue("@dueDate", dtpDueDate.Value.Date);
                        cmdLoan.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                        cmdLoan.ExecuteNonQuery();
                    }

                    // --- ACTION 2: Insert into the ORIGINAL 'issued_books' table ---
                    string insertIssued = @"INSERT INTO issued_books (book_id, member_id, issue_date, due_date, description) 
                                            VALUES (@bookId, @memberId, @issueDate, @dueDate, @description)";

                    using (MySqlCommand cmdIssued = new MySqlCommand(insertIssued, conn))
                    {
                        cmdIssued.Parameters.AddWithValue("@bookId", validatedBookId);
                        cmdIssued.Parameters.AddWithValue("@memberId", validatedMemberId);
                        cmdIssued.Parameters.AddWithValue("@issueDate", dtpIssueDate.Value.Date);
                        cmdIssued.Parameters.AddWithValue("@dueDate", dtpDueDate.Value.Date);
                        cmdIssued.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                        cmdIssued.ExecuteNonQuery();
                    }

                    // --- ACTION 3: Update Book Inventory ---
                    // If this was the very last copy, change status to 'Unavailable', otherwise keep it 'Available'
                    string updateBookStatus = (currentCopies == 1) ? "Unavailable" : "Available";

                    string updateBook = "UPDATE books SET available_copies = available_copies - 1, status = @status WHERE book_id = @bookId";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(updateBook, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@status", updateBookStatus);
                        cmdUpdate.Parameters.AddWithValue("@bookId", validatedBookId);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book successfully issued and recorded in both tables!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}