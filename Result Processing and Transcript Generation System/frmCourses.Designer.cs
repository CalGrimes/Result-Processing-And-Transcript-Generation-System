
namespace Result_Processing_and_Transcript_Generation_System
{
    partial class frmCourses
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniDataDataSet = new Result_Processing_and_Transcript_Generation_System.UniDataDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseCodeDataGridViewTextBoxColumn,
            this.courseSubjectDataGridViewTextBoxColumn,
            this.modulesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "Course code";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "Course code";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            // 
            // courseSubjectDataGridViewTextBoxColumn
            // 
            this.courseSubjectDataGridViewTextBoxColumn.DataPropertyName = "Course subject";
            this.courseSubjectDataGridViewTextBoxColumn.HeaderText = "Course subject";
            this.courseSubjectDataGridViewTextBoxColumn.Name = "courseSubjectDataGridViewTextBoxColumn";
            // 
            // modulesDataGridViewTextBoxColumn
            // 
            this.modulesDataGridViewTextBoxColumn.DataPropertyName = "Modules";
            this.modulesDataGridViewTextBoxColumn.HeaderText = "Modules";
            this.modulesDataGridViewTextBoxColumn.Name = "modulesDataGridViewTextBoxColumn";
            // 
            // courseTableBindingSource
            // 
            this.courseTableBindingSource.DataMember = "CourseTable";
            this.courseTableBindingSource.DataSource = this.uniDataDataSet;
            // 
            // uniDataDataSet
            // 
            this.uniDataDataSet.DataSetName = "UniDataDataSet";
            this.uniDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 510);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCourses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.frmCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniDataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UniDataDataSet uniDataDataSet;
        private System.Windows.Forms.BindingSource courseTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulesDataGridViewTextBoxColumn;
    }
}