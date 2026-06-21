using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class ManageMembers : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=library_db;";

        public ManageMembers()
        {
            InitializeComponent();

            // 1. Load data instantly the millisecond the window opens
            LoadMembersData();
        }

        private void LoadMembersData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 2. Fetch the specific columns matching your UI design
                    // Added ORDER BY id DESC so the newest members appear at the very top
                    string query = "SELECT member_id, full_name, gender, email, phone_number, membership_type, status FROM members ORDER BY id DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // 3. Stop the grid from creating duplicate, unformatted columns
                            dataGridView1.AutoGenerateColumns = false;

                            // 4. Inject the MySQL data into the visual table
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading member data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 5. The code for your "Add New Member" button
        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            // Make sure the name matches whatever you named your Add Member form!
            PopupAddMember addForm = new PopupAddMember();

            // Open as a strict popup. Code pauses here.
            addForm.ShowDialog();

            // The exact second the Add Member popup closes, this line runs and refreshes the table!
            LoadMembersData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked a valid row
            if (e.RowIndex >= 0)
            {
                // Grab the Member ID (e.g., M001) from the clicked row
                string selectedMemberId = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                string clickedColumn = dataGridView1.Columns[e.ColumnIndex].Name;

                // --- BUTTON 1: VIEW MEMBER INFO ---
                if (clickedColumn == "btnView")
                {
                    ViewMemberForm viewForm = new ViewMemberForm(selectedMemberId);
                    viewForm.ShowDialog();
                }

                // --- BUTTON 2: UPDATE MEMBER ---
                else if (clickedColumn == "btnUpdate")
                {
                    UpdateMemberForm updateForm = new UpdateMemberForm(selectedMemberId);
                    updateForm.ShowDialog();

                    // Refresh table instantly after updating
                    LoadMembersData();
                }

                // --- BUTTON 3: DELETE MEMBER ---
                else if (clickedColumn == "btnDelete")
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to permanently delete member {selectedMemberId}?",
                                                                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            try
                            {
                                conn.Open();
                                string deleteQuery = "DELETE FROM members WHERE member_id = @id";
                                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", selectedMemberId);
                                    cmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Member deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadMembersData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error deleting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}