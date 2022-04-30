using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace IMGPROCAPP_WINDESKTOP
{
    internal class window
    {
        private string win_name = "";
        private int width = 0;
        private int height = 0;
        private float coeff_change_ratio = 0.6f;
        public window(string winName)
        {
            win_name = winName;
        }
        private void calcRatioWithSCR(Mat img) {

            float scrWidth = Screen.PrimaryScreen.WorkingArea.Width;
            float scrHeight = Screen.PrimaryScreen.WorkingArea.Height;
            float imgWidth = img.Width;
            float imgHeight = img.Height;
            float ratio = 0.0f;

            if (imgWidth > imgHeight) {
                ratio = (scrWidth / imgWidth);
            }
            else {
                ratio = (scrHeight / imgHeight);
            }

            width = (int)(imgWidth * ratio);
            height = (int)(imgHeight * ratio);
        }

        public void setWindow(Mat img, object btnSender) {

            if(img == null)
            {
                Button btn = btnSender as Button;
                MessageBox.Show("Failed on setWindow :: Button " + btn.Text);
                return;
            }
            
            calcRatioWithSCR(img);  // calculate window size with screen size.

            Cv2.NamedWindow(win_name, WindowFlags.Normal);
            Cv2.ResizeWindow(win_name, (int)(width * coeff_change_ratio), (int)(height* coeff_change_ratio));
        }

    }
}
