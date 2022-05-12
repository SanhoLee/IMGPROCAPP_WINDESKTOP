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
        public static string WINDOW_MASK = "WINDOW_MASK";



        public static Mat imgRead = new Mat();
        public static Mat imgWork = new Mat();
        public static Mat imgGray = new Mat();
        public static Mat imgCut = new Mat();
        public static Mat imgMask = new Mat();
        public static Mat imgProc = new Mat();

        public static Rect cutRect_G = new Rect();
        public static int numPolyPnts;

        public static List<OpenCvSharp.Point> lstSqrtPnts = new List<OpenCvSharp.Point>();
        public static List<OpenCvSharp.Point> lstPolyPnts = new List<OpenCvSharp.Point>();
        public static List<List<OpenCvSharp.Point>> lstPolyElems = new List<List<OpenCvSharp.Point>>();

        // edge detector(canny) and blur img.
        public static double lowThres = 130.0f;
        public static double highThres = 250.0f;
        public static int ksize = 3;

        private  int _ALL = 0;
        private  int _PROC = 1;
        private  int _LIST = 2;




        public form_caseA()
        {
            InitializeComponent();
        }

        private void form_caseA_Load(object sender, EventArgs e)
        {
            // initializing...
            init_status(_ALL);

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
                    pic_rst.Image = null;

                    btn_cutImg.Enabled = true;
                    btn_maskImg.Enabled = true;
                    btn_clr_proc.Enabled = true;
                    btn_set_Params.Enabled = true;
                    btn_run_proc.Enabled = true;

                    init_status(_LIST);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            init_status(_ALL);
        }

        private void btn_clr_proc_Click(object sender, EventArgs e)
        {
            init_status(_PROC);
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


            while (true)
            {
                Cv2.ImShow(WINDOW_CUT, imgWork);
                int rtnKey = Cv2.WaitKey(0);

                if (rtnKey == 32 && lstSqrtPnts.Count() == 2)    // space bar key
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
                        break;
                    }
                    else
                    {

                    }
                }
                else { continue; }
            }



        }

        private void btn_maskImg_Click(object sender, EventArgs e)
        {
            Mat imgObj = new Mat();
            btn_maskImg.Enabled = false;
            numPolyPnts = 0;

            if(imgCut == null) { imgObj = imgRead.Clone();}
            else { imgObj = imgCut.Clone();}


            // create window...
            window winMask = new window(WINDOW_MASK);
            winMask.setWindow(imgObj, sender);

            // make callback instance.
            mousecallback_imgmask mcImgMask = new mousecallback_imgmask();

            // set mouse event handler...
            imgWork = imgObj.Clone();
            Cv2.SetMouseCallback(WINDOW_MASK, mcImgMask.callBackFunc);

            while (true)
            {
                Cv2.ImShow(WINDOW_MASK, imgWork);
                int rtnKey = Cv2.WaitKey(0);

                if (rtnKey == 32 && lstPolyElems.Count != 0)    // space bar key
                {
                    string msg = "Mask img ? ";
                    string caption = "Confirm Mask Img";
                    MessageBoxButtons msgBoxBtn = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(msg, caption, msgBoxBtn);
                    if (result == DialogResult.Yes)
                    {
                        dlgProc_maskImg();
                        Cv2.DestroyWindow(WINDOW_MASK);
                        break;
                    }
                    else
                    {
                        numPolyPnts = 0;
                    }
                }
                else { continue; }
            }
        }

        private void btn_run_proc_Click(object sender, EventArgs e)
        {

            // make gray img from src.
            Mat imgObj = getCurrentImg();
            if (imgObj.Type() != MatType.CV_8UC1)
            {
                Cv2.CvtColor(imgObj, imgObj, ColorConversionCodes.BGR2GRAY);
            }

            

            edgeDetector edCanny = new edgeDetector(imgObj);
            edCanny.ksize = ksize;
            edCanny.lowThres = lowThres;
            edCanny.highThres = highThres;

            edCanny.blurImg();
            Mat imgCanny = edCanny.detectEdge();

            // show on result picturebox.
            pic_rst.Image = BitmapConverter.ToBitmap(imgCanny);
            imgProc = imgCanny.Clone();
            imgCanny.Dispose();

            btn_Save.Enabled = true;
        }

        private void dlgProc_cutImg() {
            Console.WriteLine("yes clicked on Cut Process...");
            btn_cutImg.Enabled = true;

            Mat rstImg = new Mat(imgRead, cutRect_G);   // cut img with rect object.
            imgCut = rstImg.Clone();

            // put cut img into result pictureBox.
            pic_rst.Image = BitmapConverter.ToBitmap(rstImg);
        }

        private void dlgProc_maskImg()
        {
            Console.WriteLine("yes clicked on Mask Process...");
            btn_maskImg.Enabled = true;

            // get current img
            Mat imgObj = getCurrentImg();

            

            // masking with poly elems
            for(int i = 0; i < lstPolyElems.Count(); i++)
            {
                Cv2.FillPoly(imgObj, InputArray.Create(lstPolyElems[i]), new Scalar(255,255,255));
            }

            // put and show masked img into result pictureBox.
            pic_rst.Image = BitmapConverter.ToBitmap(imgObj);

            // update img data
            imgMask = imgObj.Clone();
            imgObj.Dispose();
        }

        private void init_status(int sw)
        {
            /*
             sw(switch)
                0 : status for loading this form.
                1 : reset running process.
             
             */

            switch (sw) {
            
                case 0:
                    // reset and clear all.
                    pic_org.Image = null;
                    pic_rst.Image = null;

                    imgRead = null;
                    imgCut = null;
                    imgMask = null;
                    imgProc = null;

                    lstSqrtPnts.Clear();
                    lstPolyPnts.Clear();
                    lstPolyElems.Clear();

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
                    // reset processing.
                    Mat imgObj = getCurrentImg();
                    pic_rst.Image = BitmapConverter.ToBitmap(imgObj);

                    btn_Save.Enabled = false;
                    break;

                case 2:
                    // only list variables.
                    lstSqrtPnts.Clear();
                    lstPolyPnts.Clear();
                    lstPolyElems.Clear();
                    break;

                default:
                    break;
            }
        }

        private Mat getCurrentImg()
        {
            Mat rtn = new Mat();

            if (imgMask != null)
            {
                rtn = imgMask.Clone();
            }
            else if (imgCut != null)
            {
                rtn = imgCut.Clone();
            }
            else
            {
                rtn = imgRead.Clone();
            }

            return rtn;
        }

        private void btn_set_Params_Click(object sender, EventArgs e)
        {
            form_params frmParams = new form_params();
            frmParams.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string msg = "Save data into CSV format ? ";
            string caption = "Confirm Save Data.";
            MessageBoxButtons msgBoxBtn = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(msg, caption, msgBoxBtn);
            if (result == DialogResult.Yes)
            {
                // save data
                Console.WriteLine("Save data...Run...");
                if(!imgProc.Empty()) {

                    Mat imgCheck = new Mat(imgProc.Size(), MatType.CV_8UC3);

                    // get non-zero pixel position as list.
                    Mat nonZeroIdx = new Mat();
                    Cv2.FindNonZero(imgProc, nonZeroIdx);

                    for (int i = 0; i < nonZeroIdx.Total(); i++)
                    {
                        OpenCvSharp.Point tempPnt = new OpenCvSharp.Point();
                        tempPnt.X = nonZeroIdx.At<OpenCvSharp.Point>(i).X;
                        tempPnt.Y = nonZeroIdx.At<OpenCvSharp.Point>(i).Y;

                        Cv2.Circle(imgCheck, tempPnt, 2, new Scalar(0, 0, 255), 2, LineTypes.Link4);
                    }

                    Cv2.ImShow("imgCheck", imgCheck);
                    Cv2.WaitKey(0);
                    // loop? findnonZero?


                    // save list element into csv format file.
                
                }
            }
            else
            {
                // Cancel
                Console.WriteLine("Cancel Save data...");
            }

        }
    }
}
