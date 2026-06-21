namespace Library_management_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void loadFormInPanel(Form childForm)
        {
            // 1. Wipe out EVERYTHING inside the panel at once
            mainpanel.Controls.Clear();
            mainpanel.AutoScroll = true;

            // 2. Prepare the form to be a "child" of the panel
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None; // Removes the title bar/borders

            // 3. Add and display
            this.mainpanel.Controls.Add(childForm);
            this.mainpanel.Tag = childForm;
            childForm.Show();
        }
        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            // You can write your code here later
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            loadFormInPanel(new ManageBooks());
        }

        private void btnBooks_Click_1(object sender, EventArgs e)
        {
            // Designer references this handler; forward to the actual implementation
            btnBooks_Click(sender, e);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            loadFormInPanel(new ManageMembers());
        }

        private void btnIssueBook_Click_1(object sender, EventArgs e)
        {
            loadFormInPanel(new IssueBook());
        }

        private void btnActiveLoan_Click(object sender, EventArgs e)
        {
            loadFormInPanel(new ActiveLoans());
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            loadFormInPanel(new Fines_Payment());
        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            loadFormInPanel(new ReturnBook());
        }
    }
}
