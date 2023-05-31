using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAccount;
using EmloyeeMenegmentF;

namespace EmloyeeMenegment
{
    public partial class Departaments : Form
    {
        //List<Department> dep = new List<Department>();
        Functions Con;

        

        public Departaments()
        {

            InitializeComponent();
            Con = new Functions();
            ListerDepartaments();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }





        private void ListerDepartaments()
        {
            string Query = "select * from DepartamentTbl";
             

            DepList.DataSource = Con.GetData(Query);
           
         
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep =  DepNameTb.Text;
                    string Query = "insert into DepartamentTbl values('{0}')";
                    Query = string.Format(Query,DepNameTb.Text);
                    Con.SetData(Query);
                    ListerDepartaments();
                    MessageBox.Show("Deppartament Added!!");
                    DepNameTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        //private void DepList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //   

        //}
          private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              DepNameTb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Update DepartamentTbl set DepName = '{0}' where DepId = {1}";                    
                    Query = string.Format(Query, DepNameTb.Text,Key);
                     Con.SetData(Query);
                    ListerDepartaments();
                    MessageBox.Show("Departament Updated!!");
                    DepNameTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartamentTbl where DepId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ListerDepartaments();
                    MessageBox.Show("Deppartament Deleted!!");
                    DepNameTb.Text = "";

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.Show();
            this.Hide();
        }

        private void SalaryLbl_Click(object sender, EventArgs e)
        {
            Salaries Obj = new Salaries();
            Obj.Show();
            this.Hide();
                
        }
    }
}
