using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public string KullaniciAdi { get; set; }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            Form2 frm = new Form2();
            if (txtUserName.Text == "admin" && txtPassword.Text =="1234")
            {
                KullaniciAdi = txtUserName.Text;
                frm.Owner = this;
                frm.Show();
                this.Hide();
                frm.SendMessage("admin");
            }
            else
            {
                DialogResult result = MessageBox.Show("Wrong Username or Password","Warning Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
            }
            
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (chk.Checked == true)
            {
                txtPassword.PasswordChar = default;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }



        //kullanıcı adı ve şifresini alınız
        //giriş yap =>2.form açılsın
    }
}
