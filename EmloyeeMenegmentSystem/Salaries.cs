using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAccount;
using EmloyeeMenegmentF;

namespace EmloyeeMenegment
{
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmloyees();
        }
        private void GetEmloyees()
        {
            string Query = "Select * from EmloyeeTbl";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);

        }
        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "Select EmpSal from EmloyeeTbl where EmpId = {0} ";
            Query = String.Format(Query, EmpCb.SelectedValue.ToString());
            foreach(DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
           
            //MessageBox.Show("" + DSal);
            if (DaysTb.Text == "")
            {
                AmountTb.Text = "$ " + (d * DSal);
            }else if(Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days Can not be Greater than 31");
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "$ " + (d * DSal);
            }
        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "select * from SalaryTbl";
                SalaryList.DataSource = Con.GetData(Query);

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + "_" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text); //!!!
                    //from Emloyee.cs
                    int Days = DSal * Convert.ToInt32(DaysTb.Text);


                    string Query = "insert into SalaryTbl values({0},{1},'{2}',{3},'{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Salary Paid!!!");
                    DaysTb.Text = "";
                }
               
            }
            catch (Exception Ex)
            {

                throw;
            }
           

        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Departaments Obj = new Departaments();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employee Obj = new Employee();
            Obj.Show();
            this.Hide();
        }
    }
}
