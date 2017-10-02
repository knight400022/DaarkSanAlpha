using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using SantoshClassMetro;

namespace KnightageCMS
{
    public partial class LoginPanel : MetroForm
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            int result = (int)db.getData("SELECT count(user_Id) from users where user_username ='" + TXT_USERNAME.Text + "' and user_password='" + TXT_PASWWORD.Text + "'");

            if (result == 1)
            {
                int userId = (int)db.getData("SELECT user_Id from users where user_username ='" + TXT_USERNAME.Text + "' and user_password='" + TXT_PASWWORD.Text + "'");
                Home homeobj = new Home(userId, this);
                homeobj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            TXT_PASWWORD.Text = string.Empty;
            TXT_USERNAME.Text = string.Empty;
        }

        private void Link_Forget_Pass_Click(object sender, EventArgs e)
        {

            if (TXT_USERNAME.Text == string.Empty)
            {
                MessageBox.Show("Enter User Name");
            }
            else
            {
                DataBase db = new DataBase();
                try
                {
                    int userid = (int)db.getData("select user_id from users where user_username='" + TXT_USERNAME.Text + "'");
                    if (userid == null)
                    {
                        MessageBox.Show("Invalid Username");
                    }
                    else
                    {
                        Forget_Password fp = new Forget_Password(userid);
                        fp.Show();
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Invalid Username");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            TXT_USERNAME.Text = string.Empty;
            TXT_PASWWORD.Text = string.Empty;
        }
    }
}
