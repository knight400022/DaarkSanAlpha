using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace SantoshClassMetro
{
    class allInOne
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cb"></param>
        public void setBatch(ComboBox cb)
        {
            DataBase db = new DataBase();
            DataTable dt = db.getDataSet("select Batch_Id,Batch_Name  From Batch_Master");
            DataRow dr = dt.NewRow();
            dr.ItemArray[0] = "";
            dr.ItemArray[1] = "";
            dt.Rows.InsertAt(dr, 0);
            cb.DataSource = dt;
            cb.DisplayMember = "Batch_Name";
            cb.ValueMember = "Batch_Id";
        }

        public void set_academic_year(ComboBox cb)
        {
            DataBase db = new DataBase();
            DataTable dt = db.getDataSet("select distinct(Academic_Year) as Academic_Year from Student_Details order by 1 desc");
            cb.DisplayMember = "Academic_Year";
            cb.ValueMember = "Academic_Year";
            cb.DataSource = dt;
            
        }

        public DataTable getStdCat(int stdCat)
        {
            DataBase db = new DataBase();
            try
            {

                return (DataTable)db.getDataSet("select Std_Id,Category_Id from Std_Cat where Std_Cat_Id=" + stdCat);

            }
            catch (InvalidCastException)
            {
                return new DataTable();
            }
        }
        public void setCategory(ComboBox cb2)
        {
            DataBase db = new DataBase();

            DataTable dt = db.getDataSet("select Category_Id,Category_Name from Category_Master");

           DataRow dr = dt.NewRow();
           dr.ItemArray[0] = "";
           dr.ItemArray[1] = "";
           dt.Rows.InsertAt(dr, 0);
           cb2.DataSource = dt;

           cb2.ValueMember = "Category_Id";
           cb2.DisplayMember = "Category_Name";
        }
        public void setSTD(ComboBox cb1)
        {
            DataBase db = new DataBase();
            DataTable dt = db.getDataSet("select Std_Id,Std_Name from Std_Details");

            DataRow dr = dt.NewRow();
            dr.ItemArray[0] = "";
            dr.ItemArray[1] = "";
            dt.Rows.InsertAt(dr, 0);
            cb1.DataSource = dt;

            cb1.ValueMember = "Std_Id";
            cb1.DisplayMember = "Std_Name";
        
        }
        public int getStd_Cat(int std_Id,int cat_Id)
        {
            DataBase db = new DataBase();
            try
            {
                return (int)db.getData("select Std_Cat_Id from Std_Cat where Std_Id=" + std_Id + " and Category_Id=" + cat_Id);
            }
            catch (NullReferenceException)
            {
                return -1;
            }
           
        }
    }
}


 
