
namespace Result_Processing_and_Transcript_Generation_System
{
    partial class frmStudents
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label student_IDLabel;
            System.Windows.Forms.Label course_codeLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label average_markLabel;
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniDataDataSet = new Result_Processing_and_Transcript_Generation_System.UniDataDataSet();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAvMark = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.studentTableTableAdapter = new Result_Processing_and_Transcript_Generation_System.UniDataDataSetTableAdapters.StudentTableTableAdapter();
            this.tableAdapterManager = new Result_Processing_and_Transcript_Generation_System.UniDataDataSetTableAdapters.TableAdapterManager();
            this.dgvSalt = new System.Windows.Forms.DataGridView();
            this.saltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltWithSHA256DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saltTableTableAdapter = new Result_Processing_and_Transcript_Generation_System.UniDataDataSetTableAdapters.SaltTableTableAdapter();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            student_IDLabel = new System.Windows.Forms.Label();
            course_codeLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            average_markLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saltTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // student_IDLabel
            // 
            student_IDLabel.AutoSize = true;
            student_IDLabel.Location = new System.Drawing.Point(904, 34);
            student_IDLabel.Name = "student_IDLabel";
            student_IDLabel.Size = new System.Drawing.Size(61, 13);
            student_IDLabel.TabIndex = 1;
            student_IDLabel.Text = "Student ID:";
            // 
            // course_codeLabel
            // 
            course_codeLabel.AutoSize = true;
            course_codeLabel.Location = new System.Drawing.Point(904, 81);
            course_codeLabel.Name = "course_codeLabel";
            course_codeLabel.Size = new System.Drawing.Size(70, 13);
            course_codeLabel.TabIndex = 3;
            course_codeLabel.Text = "Course code:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(904, 128);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(904, 175);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(904, 222);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(58, 13);
            first_nameLabel.TabIndex = 9;
            first_nameLabel.Text = "First name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(904, 269);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 11;
            surnameLabel.Text = "Surname:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(904, 316);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "Address:";
            // 
            // average_markLabel
            // 
            average_markLabel.AutoSize = true;
            average_markLabel.Location = new System.Drawing.Point(904, 363);
            average_markLabel.Name = "average_markLabel";
            average_markLabel.Size = new System.Drawing.Size(76, 13);
            average_markLabel.TabIndex = 15;
            average_markLabel.Text = "Average mark:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.courseCodeDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.averageMarkDataGridViewTextBoxColumn});
            this.dgvStudents.DataSource = this.studentTableBindingSource;
            this.dgvStudents.Location = new System.Drawing.Point(39, 25);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudents.Size = new System.Drawing.Size(842, 224);
            this.dgvStudents.TabIndex = 0;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "Course code";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "Course code";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // averageMarkDataGridViewTextBoxColumn
            // 
            this.averageMarkDataGridViewTextBoxColumn.DataPropertyName = "Average mark";
            this.averageMarkDataGridViewTextBoxColumn.HeaderText = "Average mark";
            this.averageMarkDataGridViewTextBoxColumn.Name = "averageMarkDataGridViewTextBoxColumn";
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "StudentTable";
            this.studentTableBindingSource.DataSource = this.uniDataDataSet;
            // 
            // uniDataDataSet
            // 
            this.uniDataDataSet.DataSetName = "UniDataDataSet";
            this.uniDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtStudentID
            // 
            this.txtStudentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Student ID", true));
            this.txtStudentID.Location = new System.Drawing.Point(994, 31);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 2;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Course code", true));
            this.txtCourseCode.Location = new System.Drawing.Point(994, 78);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 20);
            this.txtCourseCode.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Username", true));
            this.txtUsername.Location = new System.Drawing.Point(994, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(994, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "First name", true));
            this.txtFirstName.Location = new System.Drawing.Point(994, 219);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Surname", true));
            this.txtSurname.Location = new System.Drawing.Point(994, 266);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(994, 313);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 14;
            // 
            // txtAvMark
            // 
            this.txtAvMark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTableBindingSource, "Average mark", true));
            this.txtAvMark.Location = new System.Drawing.Point(994, 360);
            this.txtAvMark.Name = "txtAvMark";
            this.txtAvMark.Size = new System.Drawing.Size(100, 20);
            this.txtAvMark.TabIndex = 16;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(941, 433);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(99, 40);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert Student Data";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // studentTableTableAdapter
            // 
            this.studentTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableTableAdapter = null;
            this.tableAdapterManager.SaltTableTableAdapter = null;
            this.tableAdapterManager.StudentTableTableAdapter = this.studentTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Result_Processing_and_Transcript_Generation_System.UniDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvSalt
            // 
            this.dgvSalt.AutoGenerateColumns = false;
            this.dgvSalt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saltDataGridViewTextBoxColumn,
            this.saltWithSHA256DataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn1});
            this.dgvSalt.DataSource = this.saltTableBindingSource;
            this.dgvSalt.Location = new System.Drawing.Point(39, 255);
            this.dgvSalt.Name = "dgvSalt";
            this.dgvSalt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSalt.Size = new System.Drawing.Size(342, 172);
            this.dgvSalt.TabIndex = 18;
            // 
            // saltDataGridViewTextBoxColumn
            // 
            this.saltDataGridViewTextBoxColumn.DataPropertyName = "Salt";
            this.saltDataGridViewTextBoxColumn.HeaderText = "Salt";
            this.saltDataGridViewTextBoxColumn.Name = "saltDataGridViewTextBoxColumn";
            // 
            // saltWithSHA256DataGridViewTextBoxColumn
            // 
            this.saltWithSHA256DataGridViewTextBoxColumn.DataPropertyName = "Salt with SHA256";
            this.saltWithSHA256DataGridViewTextBoxColumn.HeaderText = "Salt with SHA256";
            this.saltWithSHA256DataGridViewTextBoxColumn.Name = "saltWithSHA256DataGridViewTextBoxColumn";
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "Student ID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "Student ID";
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            // 
            // saltTableBindingSource
            // 
            this.saltTableBindingSource.DataMember = "SaltTable";
            this.saltTableBindingSource.DataSource = this.uniDataDataSet;
            // 
            // saltTableTableAdapter
            // 
            this.saltTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Location = new System.Drawing.Point(941, 387);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(99, 40);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(1046, 386);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 40);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(1046, 433);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1236, 526);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.dgvSalt);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(average_markLabel);
            this.Controls.Add(this.txtAvMark);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(course_codeLabel);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(student_IDLabel);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.dgvStudents);
            this.Name = "frmStudents";
            this.Text = "frmStudents";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saltTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private UniDataDataSet uniDataDataSet;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private UniDataDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageMarkDataGridViewTextBoxColumn;
        private UniDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAvMark;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvSalt;
        private System.Windows.Forms.BindingSource saltTableBindingSource;
        private UniDataDataSetTableAdapters.SaltTableTableAdapter saltTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltWithSHA256DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
    }
}