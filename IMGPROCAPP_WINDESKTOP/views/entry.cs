using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMGPROCAPP_WINDESKTOP
{
    public partial class frm_entry : Form
    {

        public frm_entry()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frm_entry_Load(object sender, EventArgs e)
        {

        }

        private void btn_CASE_A_Click(object sender, EventArgs e)
        {
            form_caseA frmA = new form_caseA();
            frmA.ShowDialog();
        }

        private void btn_CASE_B_Click(object sender, EventArgs e)
        {
            form_caseB frmB = new form_caseB();
            frmB.ShowDialog();
        }
    }
}
