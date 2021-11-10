using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;

using System.Data.OleDb;

namespace Result_Processing_and_Transcript_Generation_System
{
    public partial class frmStudents : Form
    {
        public int studentID
        {
            get; set;
        }
        public string courseCode
        {
            get; set;
        }
        public string username
        {

            get; set;
        }
        public string password
        {
            get; set;
        }
        public string firstname
        {
            get; set;
        }
        public string surname
        {
            get; set;
        }
        public string address
        {
            get; set;
        }
        public double averageMark
        {
            get; set;
        }


        public frmStudents(int studentID, string courseCode, string username, string password, string firstname, string surname, string address, double averageMark)
        {
            this.studentID = studentID;
            this.courseCode = courseCode;
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.surname = surname;
            this.address = address;
            this.averageMark = averageMark;
        }


        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            txtAvMark.Text = "0";
            // TODO: This line of code loads data into the 'uniDataDataSet.Salt_Table' table. You can move, or remove it, as needed.
            this.saltTableTableAdapter.Fill(this.uniDataDataSet.SaltTable);
            this.studentTableTableAdapter.Fill(this.uniDataDataSet.StudentTable);
            //string ID = dgvStudents.Rows[dgvStudents.RowCount - 1].Cells[0].Value.ToString();

 

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Add data to Class
            frmStudents studentData = new frmStudents();

            studentData.studentID = Int32.Parse(txtStudentID.Text);
            studentData.courseCode = txtCourseCode.Text;
            studentData.username = txtUsername.Text;
            string salt = CreateSalt(10);
            studentData.password = GenerateSHA265Hash(txtPassword.Text, salt);
            studentData.firstname = txtFirstName.Text;
            studentData.surname = txtSurname.Text;
            studentData.address = txtAddress.Text;
            studentData.averageMark = double.Parse(txtAvMark.Text);



            //Add Student Data and Salt Data to DB
            bool err = false;

            err = CreateCommand("INSERT INTO StudentTable (`Student ID`, `Course code`, `Username`, `Password`, `First name`, `Surname`, `Address`, `Average mark`) VALUES ('" + studentData.studentID + "', '" + studentData.courseCode + "', '" + studentData.username + "', '" + studentData.password + "', '" + studentData.firstname + "', '" + studentData.surname + "', '" + studentData.address + "', '" + studentData.averageMark + "')", @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\UniData.accdb;Jet OLEDB:Database Password=password");

            if (err == true)
            { }
            else
            {
                MessageBox.Show("Student Sucessfully Added to Database", "Success!");
                err = CreateCommand("INSERT INTO SaltTable (`Salt`, `Salt with SHA256`, `Student ID`) VALUES ('" + salt + "', '" + studentData.password + "', '" + studentData.studentID + "')", @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\UniData.accdb;Jet OLEDB:Database Password=password");
                MessageBox.Show("Password Sucessfully Added to Database", "Success!");
            }
               


        }

        public String CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        public string GenerateSHA265Hash(string input, string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            return BitConverter.ToString(bytes);
        }

        private bool CreateCommand(string queryString, string connectionString)
        {
            // SqlConnection conn = new SqlConnection(connectionString);
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(queryString);
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error: Duplicate Student ID!");
                    return true;
                }

            }
            


        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if(txtStudentID.Text == "") { 
                btnNext.Enabled = false;
                btnNext.FlatStyle = FlatStyle.System;

                btnPrevious.Enabled = false;
                btnPrevious.FlatStyle = FlatStyle.System;
            }
            else { 
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;

                btnNext.FlatStyle = FlatStyle.Popup;
                btnPrevious.FlatStyle = FlatStyle.Popup;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvStudents.ClearSelection();
            dgvStudents.Rows[dgvStudents.Rows.Count -1].Selected = true;

            txtStudentID.Text = int.Parse(dgvStudents.Rows[dgvStudents.Rows.Count-2].Cells[0].Value.ToString()) + 1 + "";

            /*txtCourseCode.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtAvMark.Text = "0";*/


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "") 
            {
                frmStudents studentData = new frmStudents();
                
            }
        }
    }

}
