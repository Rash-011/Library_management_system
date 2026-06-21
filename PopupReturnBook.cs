using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class PopupReturnBook : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        // These hold the official IDs once a search finds an active loan
        private string activeLoanId = "";
        private string activeBookId = "";
        private DateTime calculatedDueDate;

        public PopupReturnBook()
        {
            InitializeComponent();
            dtpReturnDate.Value = DateTime.Now; // Set to today by default
        }

        // --- 1. THE DUAL-VERIFICATION SEARCH ---
        // Both search buttons will use this single method to ensure perfect accuracy
        private void PerformExactSearch()
        {
            string bookSearch = txtSearchBook.Text.Trim();
            string memberSearch = txtSearchMember.Text.Trim();

            // Guardrail: Force the user to enter BOTH pieces of information
            if (string.IsNullOrEmpty(bookSearch) || string.IsNullOrEmpty(memberSearch))
            {
                MessageBox.Show("Because multiple copies exist, please enter BOTH the Book (ID/Name) AND the Member (ID/Name) to find the exact loan.", "Information Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // STRICT QUERY: Demands that BOTH the book AND the member match the active loan
                    string query = @"SELECT l.loan_id, l.book_id, l.issue_date, l.due_date, m.member_id 
                                     FROM loans l
                                     JOIN books b ON l.book_id = b.book_id
                                     JOIN members m ON l.member_id = m.member_id
                                     WHERE (b.book_id = @bTerm OR b.book_title LIKE @bLikeTerm) 
                                     AND (m.member_id = @mTerm OR m.full_name LIKE @mLikeTerm) 
                                     AND l.status = 'Active' LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Book Parameters
                        cmd.Parameters.AddWithValue("@bTerm", bookSearch);
                        cmd.Parameters.AddWithValue("@bLikeTerm", "%" + bookSearch + "%");

                        // Member Parameters
                        cmd.Parameters.AddWithValue("@mTerm", memberSearch);
                        cmd.Parameters.AddWithValue("@mLikeTerm", "%" + memberSearch + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                activeLoanId = reader["loan_id"].ToString();
                                activeBookId = reader["book_id"].ToString();
                                calculatedDueDate = Convert.ToDateTime(reader["due_date"]);

                                // Auto-fill the textboxes to strictly lock them in
                                txtSearchBook.Text = activeBookId;
                                txtSearchMember.Text = reader["member_id"].ToString();

                                lblIssueId.Text = activeLoanId;
                                lblIssueDate.Text = Convert.ToDateTime(reader["issue_date"]).ToString("yyyy-MM-dd");
                                lblDueDate.Text = calculatedDueDate.ToString("yyyy-MM-dd");

                                // Instantly calculate the fine
                                CalculateFine();
                            }
                            else
                            {
                                MessageBox.Show("No active loan found matching BOTH this Book and this Member.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetFields();
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

        // Wire both UI buttons to the same powerful search method
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            PerformExactSearch();
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            PerformExactSearch();
        }

        // --- 2. AUTO-CALCULATE FINES ---
        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateFine();
        }

        private void CalculateFine()
        {
            if (string.IsNullOrEmpty(activeLoanId)) return;

            DateTime returnDate = dtpReturnDate.Value.Date;

            if (returnDate > calculatedDueDate.Date)
            {
                int daysLate = (returnDate - calculatedDueDate.Date).Days;
                int fineAmount = daysLate * 20; // Rs. 20 per day

                lblDaysLate.Text = daysLate.ToString();
                lblFine.Text = fineAmount.ToString();
            }
            else
            {
                lblDaysLate.Text = "0";
                lblFine.Text = "0";
            }
        }

        // --- 3. CONFIRM RETURN BUTTON ---
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(activeLoanId))
            {
                MessageBox.Show("Please search for a valid active loan first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    int daysLate = int.Parse(lblDaysLate.Text);
                    decimal fineAmount = decimal.Parse(lblFine.Text);
                    string fineStatus = "No Fine";

                    // STEP A: Ask if the fine is paid right now
                    if (fineAmount > 0)
                    {
                        DialogResult paymentResult = MessageBox.Show(
                            $"This book is {daysLate} days late. Total Fine: Rs. {fineAmount}\n\nHas the member paid this fine right now?",
                            "Overdue Fine", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        fineStatus = (paymentResult == DialogResult.Yes) ? "Paid" : "Unpaid";

                        // Create the fine record in the Fines table
                        string insertFine = "INSERT INTO fines (loan_id, fine_amount, days_late, status) VALUES (@loanId, @fine, @days, @status)";
                        using (MySqlCommand cmdFine = new MySqlCommand(insertFine, conn))
                        {
                            cmdFine.Parameters.AddWithValue("@loanId", activeLoanId);
                            cmdFine.Parameters.AddWithValue("@fine", fineAmount);
                            cmdFine.Parameters.AddWithValue("@days", daysLate);
                            cmdFine.Parameters.AddWithValue("@status", fineStatus);
                            cmdFine.ExecuteNonQuery();
                        }
                    }

                    // STEP B: Update the Loan to 'Returned' 
                    string updateLoan = @"UPDATE loans SET return_date = @returnDate, no_of_due_days = @daysLate, 
                                          fine_amount = @fineAmount, fine_status = @fineStatus, status = 'Returned' 
                                          WHERE loan_id = @loanId";
                    using (MySqlCommand cmdLoan = new MySqlCommand(updateLoan, conn))
                    {
                        cmdLoan.Parameters.AddWithValue("@returnDate", dtpReturnDate.Value.Date);
                        cmdLoan.Parameters.AddWithValue("@daysLate", daysLate);
                        cmdLoan.Parameters.AddWithValue("@fineAmount", fineAmount);
                        cmdLoan.Parameters.AddWithValue("@fineStatus", fineStatus);
                        cmdLoan.Parameters.AddWithValue("@loanId", activeLoanId);
                        cmdLoan.ExecuteNonQuery();
                    }

                    // STEP C: Add 1 copy back to the books table!
                    string updateBook = "UPDATE books SET available_copies = available_copies + 1, status = 'Available' WHERE book_id = @bookId";
                    using (MySqlCommand cmdBook = new MySqlCommand(updateBook, conn))
                    {
                        cmdBook.Parameters.AddWithValue("@bookId", activeBookId);
                        cmdBook.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book successfully returned and inventory updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetFields()
        {
            activeLoanId = ""; activeBookId = "";
            lblIssueId.Text = "-"; lblIssueDate.Text = "-";
            lblDueDate.Text = "-"; lblDaysLate.Text = "0"; lblFine.Text = "0";
        }
    }
}