using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result_Processing_and_Transcript_Generation_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmStudents f2 = new frmStudents();
            f2.Show();
        }
    }
}
