using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private bool isCellClick;
        private Timer doubleClickTimer;
        public MainForm()
        {
            InitializeComponent();
            doubleClickTimer = new Timer();
            doubleClickTimer.Interval = SystemInformation.DoubleClickTime;
            doubleClickTimer.Tick += DoubleClickTimer_Tick;

            EmployeeRecordDataGridView.CellClick += EmployeeRecordDataGridView_CellClick;
        }
        
        SqlConnection conn = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployeesRecord();
        }

        private void GetEmployeesRecord()
        {
            
            SqlCommand cmd = new SqlCommand("GetEmployees", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            EmployeeRecordDataGridView.DataSource = dt;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEditEmployeeForm form = new AddEditEmployeeForm();
            form.ShowDialog();
        }

        private void EmployeeRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCellClick = true;
            doubleClickTimer.Start();
        }

        private void EmployeeRecordDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isCellClick = false;
            AddEditEmployeeForm f2 = new AddEditEmployeeForm();
            f2.txtEmployeeID.Text = this.EmployeeRecordDataGridView.CurrentRow.Cells[0].Value.ToString();
            f2.txtFirstName.Text = this.EmployeeRecordDataGridView.CurrentRow.Cells[1].Value.ToString();
            f2.txtLastName.Text = this.EmployeeRecordDataGridView.CurrentRow.Cells[2].Value.ToString();
            f2.txtDepartment.Text = this.EmployeeRecordDataGridView.CurrentRow.Cells[3].Value.ToString();
            f2.txtSalary.Text = this.EmployeeRecordDataGridView.CurrentRow.Cells[4].Value.ToString();

            f2.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetEmployeesRecord();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Employees where Department like '%"+txtSearch.Text+"%'", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            EmployeeRecordDataGridView.DataSource = dt;
        }

        private void DoubleClickTimer_Tick(object sender, EventArgs e)
        {
            doubleClickTimer.Stop();

            if (isCellClick)
            {
                EmployeeDetailsForm form = new EmployeeDetailsForm();
                form.FirstName.Text = this.EmployeeRecordDataGridView.CurrentRow.Cells[1].Value.ToString();
                form.LastName.Text = this.EmployeeRecordDataGridView.CurrentRow.Cells[2].Value.ToString();
                form.Department.Text = this.EmployeeRecordDataGridView.CurrentRow.Cells[3].Value.ToString();
                form.Salary.Text = this.EmployeeRecordDataGridView.CurrentRow.Cells[4].Value.ToString();

                form.ShowDialog();
            }

            isCellClick = false;
        }
    }
}
