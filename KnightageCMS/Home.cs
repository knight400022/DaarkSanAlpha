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
using System.IO;

namespace KnightageCMS
{
    public partial class Home : MetroForm
    {

        int module;
        public static int user_Id;
        string Role;
        Form login;
        public Home(int userId, Form loginobj)
        {
            InitializeComponent();
            login = loginobj;
            lbl_date.Text = DateTime.Today.ToString();
            lbl_time.Text = DateTime.Now.ToString().Substring(10);
            DataBase db = new DataBase();
            DataTable dt = db.getDataSet("Select * from users where User_Id =" + userId);
            label2.Text = "Welcome " + dt.Rows[0].ItemArray[1];
            user_Id = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            Image im = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\UserImg\\user.jpg");
            pb_user.BackgroundImage = im;

            try
            {
                pb_user.BackgroundImage = Image.FromFile(dt.Rows[0].ItemArray[9].ToString());
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("User Image Not Available");
            }


            Role = (string)dt.Rows[0].ItemArray[8].ToString();
            if (Role != "Admin")
            {
                lbtn_users.Visible = false;
                lbtn_roles.Visible = false;
            }
            pnl_att.Visible = false;
            pnl_fees.Visible = false;
            pnl_report.Visible = false;
            pnl_st.Visible = false;
            pnl_stud.Visible = false;
            timer1.Start();
        }


        public void checkRole(string Role_Name, int module_id, string permission, Form obj)
        {
            DataBase db = new DataBase();
            try
            {
                string rights = (string)db.getData("select rights from user_Roles where Module=" + module_id + " and Role_Name='" + Role_Name + "'");
                if (rights == "W")
                {
                    obj.Show();
                }
                else if (rights == permission)
                {
                    obj.Show();
                }
                else if (rights == null)
                {
                    MessageBox.Show("There are no permisssions assigned to you for this module " + Environment.NewLine + "Please Contact admin to assign permissions");
                }
                else
                {
                    MessageBox.Show("You don't  not have permission  to see  this");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There are no permisssions assigned to you for this module " + Environment.NewLine + "Please Contact admin to assign permissions");
            }

        }
        private void Stud_tile_MouseHover(object sender, EventArgs e)
        {
            (sender as MetroFramework.Controls.MetroTile).Width = (sender as MetroFramework.Controls.MetroTile).Width + 20;
            (sender as MetroFramework.Controls.MetroTile).Height = (sender as MetroFramework.Controls.MetroTile).Height + 20;
            int xpt = (sender as MetroFramework.Controls.MetroTile).Location.X - 10;
            int ypt = (sender as MetroFramework.Controls.MetroTile).Location.Y - 10;
            Point p = new Point(xpt, ypt);
            (sender as MetroFramework.Controls.MetroTile).Location = p;
        }

        private void Stud_tile_MouseLeave(object sender, EventArgs e)
        {

            (sender as MetroFramework.Controls.MetroTile).Width = (sender as MetroFramework.Controls.MetroTile).Width - 20;
            (sender as MetroFramework.Controls.MetroTile).Height = (sender as MetroFramework.Controls.MetroTile).Height - 20;
            int xpt = (sender as MetroFramework.Controls.MetroTile).Location.X + 10;
            int ypt = (sender as MetroFramework.Controls.MetroTile).Location.Y + 10;
            Point p = new Point(xpt, ypt);
            (sender as MetroFramework.Controls.MetroTile).Location = p;
            switch ((sender as MetroFramework.Controls.MetroTile).Text)
            {
                case "STUDENTS":
                case "STANDARDS": (sender as MetroFramework.Controls.MetroTile).Style = MetroColorStyle.Yellow;
                    break;
                case "ATTENDENCE":
                case "FEES": (sender as MetroFramework.Controls.MetroTile).Style = MetroColorStyle.Green;
                    break;
                case "REPORTS": (sender as MetroFramework.Controls.MetroTile).Style = MetroColorStyle.Orange;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {

            if (panel3.Height < 500)
            {

                for (int i = 0; i < 45; i++)
                {

                    panel3.Width = panel3.Width + 5;
                    panel3.Height = panel3.Height + 11;
                    int xpt = panel3.Location.X;
                    int ypt = panel3.Location.Y - 11;
                    Point p = new Point(xpt, ypt);
                    panel3.Location = p;
                    int x2pt = panel2.Location.X + 7;
                    panel2.Width = panel2.Width - 7;
                    p = new Point(x2pt, panel2.Location.Y);
                    panel2.Location = p;
                }
                panel3.Location = new Point(panel3.Location.X, 169);
            }
            else
            {

                for (int i = 0; i < 45; i++)
                {
                    panel3.Width = panel3.Width - 5;
                    panel3.Height = panel3.Height - 11;
                    int xpt = panel3.Location.X;
                    int ypt = panel3.Location.Y + 11;
                    int x2pt = panel2.Location.X - 7;
                    Point p = new Point(xpt, ypt);

                    panel3.Location = p;
                    panel2.Width = panel2.Width + 7;
                    p = new Point(x2pt, panel2.Location.Y);
                    panel2.Location = p;
                }
            }

        }
        bool st = false, at = false, fe = false, sd = false, re = false;
        private void btn_stud_Click(object sender, EventArgs e)
        {

            switch ((sender as MetroFramework.Controls.MetroButton).Text)
            {
                case "Students":
                    if (st == false)
                    {
                        st = true;
                        resetBtn();
                        setPanel(pnl_stud);

                        btn_Att.Location = new Point(btn_Att.Location.X, btn_Att.Location.Y + 65);
                        btn_Fees.Location = new Point(btn_Fees.Location.X, btn_Fees.Location.Y + 65);
                        btn_stat.Location = new Point(btn_stat.Location.X, btn_stat.Location.Y + 65);
                        btn_Rept.Location = new Point(btn_Rept.Location.X, btn_Rept.Location.Y + 65);

                    }
                    else
                    {
                        st = false;
                        resetBtn();
                    }
                    break;
                case "Attendance":
                    if (at == false)
                    {
                        at = true;
                        resetBtn();
                        setPanel(pnl_att);
                        btn_Fees.Location = new Point(btn_Fees.Location.X, btn_Fees.Location.Y + 65);
                        btn_stat.Location = new Point(btn_stat.Location.X, btn_stat.Location.Y + 65);
                        btn_Rept.Location = new Point(btn_Rept.Location.X, btn_Rept.Location.Y + 65);
                    }
                    else
                    {
                        at = false;
                        resetBtn();
                    }
                    break;
                case "Fees":
                    if (fe == false)
                    {
                        fe = true;
                        resetBtn();
                        setPanel(pnl_fees);
                        btn_stat.Location = new Point(btn_stat.Location.X, btn_stat.Location.Y + 65);
                        btn_Rept.Location = new Point(btn_Rept.Location.X, btn_Rept.Location.Y + 65);

                    }
                    else
                    {
                        fe = false;
                        resetBtn();
                    }
                    break;
                case "Standards":
                    if (sd == false)
                    {
                        sd = true;
                        resetBtn();
                        setPanel(pnl_st);
                        btn_Rept.Location = new Point(btn_Rept.Location.X, btn_Rept.Location.Y + 65);
                    }
                    else
                    {
                        sd = false;
                        resetBtn();
                    }
                    break;
                case "Reports":
                    if (re == false)
                    {
                        re = true;
                        resetBtn();
                        setPanel(pnl_report);

                        //.Location = new Point(btn_Att.Location.X, btn_Att.Location.Y + 65);
                        // btn_Fees.Location = new Point(btn_Fees.Location.X, btn_Fees.Location.Y + 65);
                        // btn_stat.Location = new Point(btn_stat.Location.X, btn_stat.Location.Y + 65);
                        // btn_Rept.Location = new Point(btn_Rept.Location.X, btn_Rept.Location.Y + 65);
                    }
                    else
                    {
                        re = false;
                        resetBtn();
                    }
                    break;
            }
        }
        public void setPanel(Panel p)
        {
            pnl_att.Visible = false;
            pnl_fees.Visible = false;
            pnl_report.Visible = false;
            pnl_st.Visible = false;
            pnl_stud.Visible = false;
            p.Visible = true;
        }
        public void resetBtn()
        {
            pnl_att.Visible = false;
            pnl_fees.Visible = false;
            pnl_report.Visible = false;
            pnl_st.Visible = false;
            pnl_stud.Visible = false;
            btn_stud.Location = new Point(35, 46);
            btn_Att.Location = new Point(35, 129);
            btn_stat.Location = new Point(35, 292);
            btn_Fees.Location = new Point(35, 213);
            btn_Rept.Location = new Point(35, 373);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panel4.Hide();
            lbl_date.Text = DateTime.Today.ToLongDateString() + "\n" + DateTime.Now.DayOfWeek.ToString();
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Stud_tile_Click(object sender, EventArgs e)
        {
            panel4.Show();
            metroButton1.Text = "Add Student";
            module = 1;
            metroButton2.Text = "View Student";
            metroButton3.Hide();
            metroButton4.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

           // panel4.Hide();
            //if (metroButton1.Text == "Add Student")
            //{
            //    Students_Details sd = new Students_Details();
            //    checkRole(Role, module, "W", sd);
            //    //sd.Show();
            //}
            //if (metroButton1.Text == "Add Attendance")
            //{
            //    Attendance_Details at = new Attendance_Details();
            //    checkRole(Role, module, "W", at);
            //}
            //if (metroButton1.Text == "Fees")
            //{
            //    Fees_Details fd = new Fees_Details();
            //    checkRole(Role, module, "W", fd);

            //}
            //if (metroButton1.Text == "STANDARDS")
            //{
            //    Fees_Details fd = new Fees_Details();
            //    checkRole(Role, module, "W", fd);

            //}
            //if (metroButton1.Text == "Combine Form")
            //{
            //    CombineForm cf = new CombineForm();
            //    checkRole(Role, module, "W", cf);
            //}
            //if (metroButton1.Text == "Attendance Report")
            //{
            //    View_AttendanceDetails vaobj = new View_AttendanceDetails();
            //    vaobj.Show();
            //}
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            panel4.Show();
            module = 2;
            metroButton1.Text = "Add Attendance";
            metroButton2.Text = "View Attendance";
            metroButton3.Show();
            metroButton3.Text = "Edit Attendance";
            metroButton4.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //if (metroButton2.Text == "View Attendance")
            //{
            //    View_AttendanceDetails vat = new View_AttendanceDetails();
            //    checkRole(Role, module, "R", vat);
            //    panel4.Hide();
            //}
            //if (metroButton2.Text == "Add Installation")
            //{
            //    module = 6;
            //    Installation_Details id = new Installation_Details();
            //    checkRole(Role, module, "R", id);
            //    panel4.Hide();
            //}
            //if (metroButton2.Text == "View Student")
            //{
            //    View_Students id = new View_Students();
            //    checkRole(Role, module, "R", id);
            //    panel4.Hide();
            //}
            //if (metroButton2.Text == "Over Due Report")
            //{
            //    ViewInstallationDetails vidObj = new ViewInstallationDetails();
            //    vidObj.Show();
            //    panel4.Hide();
            //}
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            module = 3;
            panel4.Show();
            metroButton1.Text = "Fees";
            metroButton2.Text = "Add Installation";
            metroButton3.Hide();
            metroButton4.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            module = 5;
            //CombineForm cfobj = new CombineForm();
            //checkRole(Role, module, "R", cfobj);
            panel4.Hide();
            metroButton4.Hide();
        }

        private void btn_att_edit_Click(object sender, EventArgs e)
        {
            //View_AttendanceDetails viweattObj = new View_AttendanceDetails();
            //viweattObj.Show();
            //resetBtn();
        }

        private void btn_add_Stud_Click(object sender, EventArgs e)
        {
            //Students_Details studObj = new Students_Details();
            //studObj.Show();
            //resetBtn();
        }

        private void btn_view_stud_Click(object sender, EventArgs e)
        {

        }

        private void btn_att_add_Click(object sender, EventArgs e)
        {
            // Attendence attObj = new Attendence();
            //  attObj.Show();
            resetBtn();
        }

        private void btn_fees_details_Click(object sender, EventArgs e)
        {
            //Fees_Details feesObj = new Fees_Details();
            //feesObj.Show();
            //resetBtn();
        }

        private void btn_installment_Click(object sender, EventArgs e)
        {
            //Installation_Details installObj = new Installation_Details();
            //installObj.Show();
            //resetBtn();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //if (metroButton3.Text == "Edit Attendance")
            //{
            //    Attendance_Details ad = new Attendance_Details("update");
            //    ad.Show();

            //}

            //if (metroButton3.Text == "Edit Installment")
            //{
            //    ViewInstallationDetails id = new ViewInstallationDetails();
            //    id.Show();
            //    panel4.Hide();
            //}
            //if (metroButton3.Text == "Fee Receipt")
            //{
            //    ViewInstallationDetails id = new ViewInstallationDetails();
            //    id.Show();
            //    panel4.Hide();
            //}
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {

            login.Show();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            module = 4;
            metroButton4.Show();
            metroButton3.Show();
            metroButton1.Text = "Attendance Report";
            metroButton2.Text = "Over Due Report";
            metroButton3.Text = "Fee Receipt";
            panel4.Show();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString().Substring(10);
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void pb_user_Click(object sender, EventArgs e)
        {
            //User_Details sdobj = new User_Details(user_Id);
            //sdobj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();

        }

        private void lbtn_users_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //View_Users vuobj = new View_Users(); 
            //vuobj.Show();
        }

        private void lbtn_roles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Manage_role mrobj = new Manage_role(); 
            //mrobj.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //ViewInstallationDetails vid = new ViewInstallationDetails("Report");
            //vid.ShowDialog();
        }



    }
}
