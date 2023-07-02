namespace WindowsFormsApp1
{
    partial class EmployeeDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(96, 185);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(47, 15);
            this.lbSalary.TabIndex = 2;
            this.lbSalary.Text = "Salary :";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartment.Location = new System.Drawing.Point(66, 143);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(78, 15);
            this.lbDepartment.TabIndex = 3;
            this.lbDepartment.Text = "Department :";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(73, 101);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(70, 15);
            this.lbLastName.TabIndex = 4;
            this.lbLastName.Text = "LastName :";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(73, 56);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(70, 15);
            this.lbFirstName.TabIndex = 5;
            this.lbFirstName.Text = "FirstName :";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FirstName.Location = new System.Drawing.Point(149, 56);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(7, 15);
            this.FirstName.TabIndex = 5;
            this.FirstName.Text = "\r\n";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LastName.Location = new System.Drawing.Point(150, 101);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(7, 15);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "\r\n";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Department.Location = new System.Drawing.Point(149, 143);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(7, 15);
            this.Department.TabIndex = 5;
            this.Department.Text = "\r\n";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Salary.Location = new System.Drawing.Point(150, 185);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(7, 15);
            this.Salary.TabIndex = 5;
            this.Salary.Text = "\r\n";
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(423, 293);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.lbFirstName);
            this.Name = "EmployeeDetailsForm";
            this.Text = "EmployeeDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        public System.Windows.Forms.Label FirstName;
        public System.Windows.Forms.Label LastName;
        public System.Windows.Forms.Label Department;
        public System.Windows.Forms.Label Salary;
    }
}