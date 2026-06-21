namespace Library_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;
            if (panel2.Width >= 800)
            {
                timer1.Stop();

                Login loginform = new Login();
                loginform.Show();
                this.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
