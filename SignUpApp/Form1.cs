using System;
using System.Windows.Forms;

namespace SignUpApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Focus();
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm password don't match !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IUserRepository repository = new UserRepository();
            bool result = await repository.Insert(new User() { UserName = txtUserName.Text, Password = txtPassword.Text, Email = txtEmail.Text, FullName = txtFullName.Text, Address = txtAddress.Text });
            if (result)
                MessageBox.Show("You have successfully signed up !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


