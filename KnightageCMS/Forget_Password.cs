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
    public partial class Forget_Password : MetroForm
    {
        string ans;
        int user_id;
        public Forget_Password(int userid)
        {
            InitializeComponent();
            user_id = userid;
            DataBase db = new DataBase();
            panel1.Visible = false;
            DataTable dt = db.getDataSet("select user_Question,user_answer from users where user_id=" + userid);
            label2.Text = "Q. " + dt.Rows[0].ItemArray[0].ToString();
            ans = dt.Rows[0].ItemArray[1].ToString();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (ans == txt_ans.Text)
            {
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong Answer");
            }
        }

        private void btn_Ch_pass_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == txt_confirm.Text)
            {
                DataBase db = new DataBase();
                int res = db.noReturn("UPDATE USERS SET user_password ='" + txt_password.Text + "' where user_id=" + user_id);
                if (res == 1)
                {
                    MessageBox.Show("Password changed Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error  in  Changing Password");

                }
            }
        }
    }
}
