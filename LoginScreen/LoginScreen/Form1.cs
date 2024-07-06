namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pwdTxt = password.Text;
            string usernameTxt = username.Text;

            if (pwdTxt.Equals("123456789") && usernameTxt.Equals("Jumah"))
            {
                MessageBox.Show("Login Successful");

            }
            else { 
                MessageBox.Show("Login Unsuccessful");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 5) {
                MessageBox.Show(tb.Text);
            
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
