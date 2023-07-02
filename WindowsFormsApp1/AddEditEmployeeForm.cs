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

namespace WindowsFormsApp1
{
    public partial class AddEditEmployeeForm : Form
    {
        public AddEditEmployeeForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True");

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtEmployeeID.Text != "")
            {
                SqlCommand command = new SqlCommand("UpdateEmployee", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                command.Parameters.AddWithValue("@Department", txtDepartment.Text);
                command.Parameters.AddWithValue("@Salary", txtSalary.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Updated Employee", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("AddEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Added New Employee", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
