using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace IMGPROCAPP_WINDESKTOP
{
    public partial class form_caseA : Form
    {
        public static string WINDOW_CUT = "WINDOW_CUT";


        public static Mat imgRead = new Mat();
        public static Mat imgWork = new Mat();
        public static Rect cutRect_G = new Rect();



        public form_caseA()
        {
            InitializeComponent();
        }

        private void form_caseA_Load(object sender, EventArgs e)
        {
            // initializing...
            init_btns(0);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgRead = Cv2.ImRead(ofd.FileName);
                    pic_org.Image = BitmapConverter.ToBitmap(imgRead);

                    btn_cutImg.Enabled = true;
                    btn_maskImg.Enabled = true;
                    btn_clr_proc.Enabled = true;
                    btn_set_Params.Enabled = true;
                    btn_run_proc.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (pic_org.Image != null) {
                pic_org.Image.Dispose();
                pic_org.Image = null;
                init_btns(0);
            }

        }


        private void btn_cutImg_Click(object sender, EventArgs e)
        {
            btn_cutImg.Enabled = false;

            // create window...
            window winCut = new window(WINDOW_CUT);
            winCut.setWindow(imgRead, sender);

            // make callback instance.
            mousecallback_imgcut mcImgCut = new mousecallback_imgcut();

            // set mouse event handler...
            imgWork = imgRead.Clone();
            Cv2.SetMouseCallback(WINDOW_CUT, mcImgCut.callBackFunc);
            Cv2.ImShow(WINDOW_CUT, imgWork);
            int rtnKey = Cv2.WaitKey(0);
            if (rtnKey == 32)    // esc key
            {
                string msg = "Cut img ? ";
                string caption = "Confirm Cut Img";
                MessageBoxButtons msgBoxBtn = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(msg, caption, msgBoxBtn);
                if (result == DialogResult.Yes)
                {
                    dlgProc_cutImg();
                    Cv2.DestroyWindow(WINDOW_CUT);
                }
                else
                {
                }
            }
            


        }

        private void dlgProc_cutImg() {
            Console.WriteLine("yes clicked...");



            btn_cutImg.Enabled = true;
        }

        private void init_btns(int sw)
        {
            /*
             sw(switch)
                0 : status for loading this form.
             
             
             
             
             */


            switch (sw) {
            
                case 0:
                    btn_clear.Enabled = true;
                    btn_load.Enabled = true;
                    btn_close.Enabled = true;
                    btn_clr_proc.Enabled = true;
                    btn_set_Params.Enabled = true;

                    btn_cutImg.Enabled = false;
                    btn_maskImg.Enabled = false;
                    btn_run_proc.Enabled = false;
                    btn_Save.Enabled = false;
                    btn_clr_proc.Enabled= false;
                    btn_set_Params.Enabled = false;
                    break;
                case 1:
                    break;

                default:
                    break;
            }







        }
    }
}
