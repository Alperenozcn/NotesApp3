using NotesApp3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var numberst = DataStore.Numbers;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUserName.Text))
            {
                if(DataStore.AppUser.UserName == txtUserName.Text && DataStore.AppUser.Password == txtPassword.Text) 
                {
                    Form1 form1= new Form1();
                    form1.Show();
                    this.Hide();
                } 
                else
                {
                    MessageBox.Show("Giriş Bilgileri Hatalı");
                }
                
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
        }
    }
}
