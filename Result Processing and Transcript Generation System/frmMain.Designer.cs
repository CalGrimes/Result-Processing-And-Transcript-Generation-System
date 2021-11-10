
namespace Result_Processing_and_Transcript_Generation_System
{
    partial class frmMain
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
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCourses.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCourses.Location = new System.Drawing.Point(188, 363);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(155, 59);
            this.btnCourses.TabIndex = 7;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStudents.Location = new System.Drawing.Point(188, 255);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(155, 59);
            this.btnStudents.TabIndex = 6;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrades.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGrades.Location = new System.Drawing.Point(188, 147);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(155, 59);
            this.btnGrades.TabIndex = 5;
            this.btnGrades.Text = "Grades";
            this.btnGrades.UseVisualStyleBackColor = false;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMainMenu.Location = new System.Drawing.Point(197, 57);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(146, 31);
            this.lblMainMenu.TabIndex = 4;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(551, 575);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.lblMainMenu);
            this.Name = "frmMain";
            this.Text = "Result Processing and Transcript Generation System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Label lblMainMenu;
    }
}

