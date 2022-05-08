using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace IMGPROCAPP_WINDESKTOP
{
    internal class edgeDetector
    {
        public Mat imgInit = new Mat();

        public double lowThres=130.0f;
        public double highThres=250.0f;
        public int ksize = 5;

        private Mat imgBlur = new Mat();
        private Mat imgCanny = new Mat();



        public edgeDetector(Mat imgRead)
        {
            Console.WriteLine("edgeDetector instance is made...");
            this.imgInit = imgRead.Clone();
            this.imgBlur =  new Mat(imgInit.Size(), MatType.CV_8UC1);
            this.imgCanny = new Mat(imgInit.Size(), MatType.CV_8UC1);
        }

        public void blurImg() {
            Cv2.GaussianBlur(imgInit, imgBlur, new OpenCvSharp.Size(ksize, ksize), 1, 0, BorderTypes.Default);
        }

        public Mat detectEdge() {
            Console.WriteLine("Method :: detectEdge is running...");

            try {
                Cv2.Canny(imgBlur, imgCanny, lowThres, highThres);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("processed with initial img");

                Cv2.Canny(imgInit, imgCanny, lowThres, highThres);
            }

            return imgCanny;
        }



        ~edgeDetector()
        {
            Console.WriteLine("edgeDetector instance is terminated...");
            GC.Collect();

        }
    }
}
