namespace BankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ResetLbl_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if (UNameTb.Text == "Admin"  && PasswordTb.Text == "Password")
            {
                Employee Obj = new Employee();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }
    }
}