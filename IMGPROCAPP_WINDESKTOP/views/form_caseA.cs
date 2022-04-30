﻿using System;
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
        private const string WINDOW_CUT = "WINDOW_CUT";


        public Mat imgRead = new Mat();


        public form_caseA()
        {
            InitializeComponent();
        }

        private void form_caseA_Load(object sender, EventArgs e)
        {

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
            }

        }


        private void btn_cutImg_Click(object sender, EventArgs e)
        {
            // create window...
            window winCut = new window(WINDOW_CUT);
            winCut.setWindow(imgRead, sender);

            // make callback instance.
            mousecallback_imgcut mcImgCut = new mousecallback_imgcut();
            
            // set mouse event handler...
            Cv2.SetMouseCallback(WINDOW_CUT, mcImgCut.callBackFunc);

            while (true)
            {
                Cv2.ImShow(WINDOW_CUT, imgRead);
                int k = Cv2.WaitKey(1);
                if (k == 27)    // esc key
                {
                    Cv2.DestroyWindow(WINDOW_CUT); 
                    Console.WriteLine("Destroy Current Window...");
                    break;
                } else if (k == -1) {
                    continue; 
                } else {
                    Console.WriteLine("now Pressed Key number : " + k);
                }
            }
            


        }
    }
}
