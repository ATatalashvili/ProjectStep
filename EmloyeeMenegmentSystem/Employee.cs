using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmloyeeMenegment;
using EmloyeeMenegmentF;

namespace BankAccount
{
    public partial class Employee : Form
    {
        Functions Con;
        public Employee()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartament();
        }
        private void ShowEmp()
        {
            try
            {
                string Query = "select * from EmloyeeTbl";
                EmployeeList.DataSource = Con.GetData(Query);

            }
            catch(Exception)
            {
                throw;
            }
            
        }
        private void GetDepartament()
        {
            string Query = "Select * from DepartamentTbl";
            DepCb.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource = Con.GetData(Query);

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "" )
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep =Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);
                    
                    string Query = "insert into EmloyeeTbl values('{0}','{1}',{2},'{3}','{4}',{5})";
                    Query = string.Format(Query,Name,Gender,Dep,DOB,JDate,Salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Added!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        //Delete
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    //string Name = EmpNameTb.Text;
                    //string Gender = GenCb.SelectedItem.ToString();
                    //int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    //string DOB = DOBTb.Value.ToString();
                    //string JDate = JDateTb.Value.ToString();
                    //int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "Delete from EmloyeeTbl where EmpId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Deleted!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //Update
        private void UbdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "Update EmloyeeTbl set EmpName = '{0}', EmpGen = '{1}', EmpDep = {2}, EmpDDB = '{3}', EmpJDate = '{4}', EmpSal = {5} where EmpId = {6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary,Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Updated!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DOBTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            JDateTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            DailySalTb.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();

            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Departaments Obj = new Departaments();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Salaries Obj = new Salaries();
            Obj.Show();
            this.Hide();
        }
    }
}
