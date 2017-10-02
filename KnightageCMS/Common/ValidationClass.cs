using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Text.RegularExpressions;

namespace SantoshClassMetro
{
    class ValidationClass
    {
        public bool chkNull(Control ctr)
        {
            if (ctr.Text.TrimEnd() == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool chkString(Control ctr)
        {
            string numcheck = @"^[a-zA-Z ]+$";
            Regex re = new Regex(numcheck);
            if (re.IsMatch(ctr.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool chkNum(Control ctr)
        {
            string numcheck = @"^[0-9]+$";
            Regex re = new Regex(numcheck);
            if (re.IsMatch(ctr.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsValidlPhone(Control ctr)
        {
            string numcheck = @"^\d{10}$";
            Regex re = new Regex(numcheck);
            if (!re.IsMatch(ctr.Text))
            {
                return false;               
            }
            else
            {
                return true;
            }
        }
        public bool IsEmail(Control ctr)
        {
            //
            string numcheck = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex re = new Regex(numcheck);
            if (!re.IsMatch(ctr.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsValidTime(Control ctr)
        {
            //
            string numcheck = @"^[0-9]+\.[0-9]+$";
            Regex re = new Regex(numcheck);
            if (!re.IsMatch(ctr.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Validations for attendance
        //
        public bool chkCurrDate(DateTime date)
        {
            if (date > DateTime.Today)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
