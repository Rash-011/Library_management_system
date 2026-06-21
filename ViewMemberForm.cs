using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class ViewMemberForm : Form
    {
        private string targetMemberId;
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public ViewMemberForm(string memberId)
        {
            InitializeComponent();
            this.targetMemberId = memberId;
            LoadMemberDetails();
        }

        private void LoadMemberDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM members WHERE member_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", targetMemberId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblFullName.Text = reader["full_name"].ToString();
                                lblGender.Text = reader["gender"].ToString();
                                lblEmail.Text = reader["email"].ToString();

                                // Format the date so it looks nice on the label
                                if (DateTime.TryParse(reader["membership_date"].ToString(), out DateTime memDate))
                                {
                                    lblMembershipDate.Text = memDate.ToString("MMMM dd, yyyy");
                                }
                                else
                                {
                                    lblMembershipDate.Text = reader["membership_date"].ToString();
                                }

                                lblNic.Text = reader["nic_student_id"].ToString();
                                lblMembershipType.Text = reader["membership_type"].ToString();
                                lblPhone.Text = reader["phone_number"].ToString();
                                lblStatus.Text = reader["status"].ToString();
                                lblAddress.Text = reader["address"].ToString();
                                lblDob.Text = reader["date_of_birth"].ToString();
                                lblDescription.Text = reader["description"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Member details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading member data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}