namespace HotelManagerment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "letrung" && txtPassword.Text == "1234")
            {
                labelError.Visible = false;
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
