using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Windows.Forms;

namespace SantoshClassMetro
{
   
class Validation
{
 ErrorProvider ep = new ErrorProvider();
 public bool test, minchk, chars, empty, dob;//test=number flag
            
            public void string_Empty_Validation(Control c, ErrorProvider e)//checking empty string
            {
                empty = false;
                if (c.Text.Trim() == string.Empty)
                {
                    empty = true;
                    //e.SetError(c, "This field must not be empty");
                    this.ep.SetError(c, "This field must not be empty");
                }
                else
                {
                    e.SetError(c, "");
                    e.Clear();
                }
            }
            public void string_Number_Validation(Control c, ErrorProvider e)//checking number only
            {
                char[] temp = c.Text.ToCharArray();
                test = false;
                for (int i = 0; i < temp.Length; i++)
                {
                    if (!char.IsNumber(temp[i]))
                    {
                        test = true;
                    }
                }
                if (test == true)
                {
                    this.ep.SetError(c, "This field must contain only number");
                }
                else
                {
                    e.SetError(c, "");
                }
            }
            public void string_MinLen_Validation(Control c, ErrorProvider e, int min)//checking min length
            {
                minchk = false;
                char[] testArr = c.Text.ToCharArray();
                if (testArr.Length != min)
                {
                    minchk = true;
                    this.ep.SetError(c, "This field must contain only " + min + " number");
                }
                else
                {
                    minchk = false;
                    e.SetError(c, "");
                }
            }
            public void string_MinLen_Empty_Validation(Control c, ErrorProvider e, int min)//checking actual length + number
            {
                if (test == true)
                {
                    string_Number_Validation(c, e);
                }
                else if (minchk == true)
                {
                    string_MinLen_Validation(c, e, min);
                }
                else
                {
                    e.SetError(c, "");
                }
            }
            public void string_Char_Validation(Control c, ErrorProvider e)//only character
            {
                char[] temp = c.Text.ToCharArray();
                chars = false;
                for (int i = 0; i < temp.Length; i++)
                {
                    if (!char.IsLetter(temp[i]))
                    {
                        chars = true;
                    }
                }
                if (chars == true)
                {
                    this.ep.SetError(c, "This field must contain only characters");
                }
                else
                {
                    e.SetError(c, "");
                }
            }
            public void string_char_Empty_Validation(Control c, ErrorProvider e)//checking char + empty
            {
                if (empty == true)
                {
                    string_Empty_Validation(c, e);
                }
                else if (chars == true)
                {
                    string_Char_Validation(c, e);
                }
                else
                {
                    e.SetError(c, "");
                }
            }
            public void string_char_num_Empty_Validation(Control c, ErrorProvider e, int min)//checking char + empty + num
            {
                if (empty == true)
                {
                    string_Empty_Validation(c, e);
                }
                else
                {
                    if (test == true)
                    {
                        string_Number_Validation(c, e);

                    }
                    else
                    {
                        if (minchk == true)
                        {
                            string_MinLen_Validation(c, e, min);
                        }
                    }
                }
            }
            public void dob_Year_Validation(DateTimePicker dtp, ErrorProvider e)//dob validation
            {
                dob = false;
                DateTimePicker dt = new DateTimePicker();
                int cur_year = Convert.ToInt32((dt.Value.Year));
                int dob_year = Convert.ToInt32((dtp.Value.Year));
                int a = cur_year - 15;
                int b = cur_year - 30;
                if ((dob_year > b) && (dob_year < a))
                {
                    dob = true;
                    e.SetError(dtp, "");
                }
                else
                {
                    this.ep.SetError(dtp, "The date must be with in range");

                }
            }
            public void string_num_Empty_Validation(Control c, ErrorProvider e)//checking num + empty
            {
                if (empty == true)
                {
                    string_Empty_Validation(c, e);
                }
                else if (test == true)
                {
                    string_Number_Validation(c, e);
                }
                else
                {
                    e.SetError(c, "");
                }
            }




            //..........................................................End of validation methods.......................................................
        }
    }