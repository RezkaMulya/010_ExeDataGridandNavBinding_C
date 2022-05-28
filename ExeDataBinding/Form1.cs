using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataBinding
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "rezka" && textBoxPassword.Text == "12345")
            {
                FormMenu mn = new FormMenu();
                mn.Show();
                this.Hide();
            }
            else if(checkBox1.Checked)
            {
                FormMenu mn = new FormMenu();
                mn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pastikan Username dan Password Anda Sudah benar!!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
