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
    public partial class form_params : Form
    {
        public form_params()
        {
            InitializeComponent();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if(num_pxLowThres.Value > num_pxHighThres.Value)
            {
                num_pxLowThres.Value = 0;
                MessageBox.Show("Check pixel Low and High Threshold Values.");
                return;

            }

            //update params variables.
            form_caseA.ksize =       (int)num_ksize.Value;
            form_caseA.lowThres =    (int)num_pxLowThres.Value;
            form_caseA.highThres =   (int)num_pxHighThres.Value;
            this.Close();
        }

        private void form_params_Load(object sender, EventArgs e)
        {
            num_ksize.Value = form_caseA.ksize;
            num_pxLowThres.Value = (decimal)form_caseA.lowThres;
            num_pxHighThres.Value = (decimal)form_caseA.highThres;
        }

        private void num_ksize_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("k-size : "+ num_ksize.Value);
            if(num_ksize.Value % 2 == 0){ num_ksize.Value += 1;}

        }
    }
}
