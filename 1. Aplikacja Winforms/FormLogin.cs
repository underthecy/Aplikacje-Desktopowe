using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homelogpro
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            if (IsUserValid(login,password))
            {
                FormHome form = new FormHome();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid, try again");
            }
        }
        private bool IsUserValid(string username, string password)
        {
            var UsersRepository = new UsersRepository();
            var isValid = UsersRepository.User.Any(u => u.Login == username && u.Password == password);
            return isValid;
        }
    }
}
