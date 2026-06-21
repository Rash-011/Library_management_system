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
    public partial class UserDashboard : Form
    {
        String signedInUser = UserSession.MemberId.ToString();
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usageReportsbtn_Click(object sender, EventArgs e)
        {
            UsageReports usageReports = new UsageReports();
            usageReports.Show();
        }

        private void searchBooksbtn_Click(object sender, EventArgs e)
        {
            UserSearchBooks userSearchBooks = new UserSearchBooks();
            userSearchBooks.Show();

        }



        private void myBooksbtn_Click(object sender, EventArgs e)
        {
            MyBooksForm myBooksForm = new MyBooksForm();
            myBooksForm.Show();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            topFullNamelbl.Text = UserSession.FullName.ToString();
            currentlyBorrowedlbl.Text=GetBorrowedBookCount(signedInUser).ToString();
            SetNextDueDate(signedInUser);
            currentlyOverduelbl.Text = GetOverdueBooksCount(signedInUser).ToString();
            totalBooksReadlbl.Text = GetTotalBooksRead(signedInUser).ToString(); 
            lastBorrowedlbl.Text = GetLastBorrowedBookTitle(signedInUser).ToString();
            lastReturedlbl.Text = GetLastReturnedBookTitle(signedInUser).ToString();

        }
        public int GetBorrowedBookCount(string userID)
        {
            string connString = "server=localhost;database=library_db;uid=root;pwd=;";

            string query = "SELECT COUNT(*) FROM loans WHERE return_date IS NULL AND member_id = @UserID";

            int occurrenceCount = 0;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    try
                    {
                        conn.Open();

                        occurrenceCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }

            return occurrenceCount;
        }

        public void SetNextDueDate(string userID)
        {
            string connString = "server=localhost;database=library_db;uid=root;pwd=;";

            string query = @"SELECT due_date FROM issued_books 
                 WHERE member_id = @MemberID
                   AND due_date >= CURDATE()
                 ORDER BY due_date ASC 
                 LIMIT 1;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MemberID", userID);
                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        DateTime nextDue = Convert.ToDateTime(result);
                        nextDueDatelbl.Text = nextDue.ToString("MMM dd, yyyy"); // e.g., Jun 24, 2026
                    }
                    else
                    {
                        nextDueDatelbl.Text = "-";
                    }
                }
            }
        }

        public int GetOverdueBooksCount(string userID)
        {
            string connString = "server=localhost;database=library_db;uid=root;pwd=;";

            // SQL query counting active loans where the due date has passed
            string query = @"SELECT COUNT(*) FROM loans 
                 WHERE member_id = @MemberID
                   AND status = 'Active'
                   AND return_date IS NULL
                   AND due_date < CURDATE();";

            int overdueCount = 0;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MemberID", userID);

                    try
                    {
                        conn.Open();

                        overdueCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }

            return overdueCount;
        }

        public int GetTotalBooksRead(string userID)
        {
            string connString = "server=localhost;database=library_db;uid=root;pwd=;";

            string query = "SELECT COUNT(*) FROM issued_books WHERE member_id = @UserID";

            int occurrenceCount = 0;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    try
                    {
                        conn.Open();

                        occurrenceCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }

            return occurrenceCount;
        }

        public string GetLastBorrowedBookTitle(string userID)
        {
            string connString = "server=localhost;database=library_db;uid=root;pwd=;";

            string query = @"SELECT b.book_title 
                     FROM loans l
                     JOIN books b ON l.book_id = b.book_id
                     WHERE l.member_id = @MemberID
                     ORDER BY l.id DESC 
                     LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MemberID", userID);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return result.ToString();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }

            // Default fallback text if the user has a completely clean transaction history
            return "No books borrowed yet";
        }

        public string GetLastReturnedBookTitle(string memberId)
        {
            string connString = "server=localhost;database=library_db;uid=root;pwd=;";

            string query = @"SELECT b.book_title 
                     FROM loans l
                     JOIN books b ON l.book_id = b.book_id
                     WHERE l.member_id = @MemberID
                       AND l.status = 'Returned'
                       AND l.return_date IS NOT NULL
                     ORDER BY l.return_date DESC, l.id DESC 
                     LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MemberID", memberId);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return result.ToString();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                        return "Error loading asset";
                    }
                }
            }

            return "No history of returned books";
        }

        private void logOutbtn_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            this.Close();
            Login loginAfterLogOut = new Login();
            loginAfterLogOut.Show();
        }

        private void myProfilebtn_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
        }

        private void finesbtn_Click(object sender, EventArgs e)
        {
            Finesbooks finesbooks = new Finesbooks();
            finesbooks.Show();
        }
    }
}
