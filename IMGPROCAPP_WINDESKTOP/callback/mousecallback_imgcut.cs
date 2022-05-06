using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace IMGPROCAPP_WINDESKTOP
{
    internal class mousecallback_imgcut
    {
        private int numSqurePnt = 0;
        private List<Point> lstSqurePnt = new List<Point>();
        private Rect rect = new Rect();

        private Mat imgShowLocal = new Mat();
        private readonly string str_winCut = form_caseA.WINDOW_CUT;


        private readonly Scalar readyColor = new Scalar(255, 0, 255);
        private readonly Scalar selectedColor = new Scalar(0, 255, 0);
        private readonly int rectThick = 5;
        private readonly int circleThick = 5;
        private readonly int circleRad = 10;

        public mousecallback_imgcut() {
            Console.WriteLine("imgcut mousecallback function is fired...");
        }

        public void callBackFunc(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userData)
        {
            if (@event == MouseEventTypes.LButtonDown) {
                procLeftBtn(x,y);
            }
            else if(@event == MouseEventTypes.MButtonDown && numSqurePnt == 2) {   // finish status.
                procMidBtn();
            }
            else if(@event == MouseEventTypes.RButtonDown) {   // reset status.
                procRightBtn();
            }

            // show working img anyway...
            if(!imgShowLocal.Empty()) {
                Cv2.ImShow(str_winCut, imgShowLocal);
            }
        }

        private void procLeftBtn(int x, int y) {
            if (numSqurePnt == 0)
            {
                imgShowLocal = form_caseA.imgWork.Clone();
                form_caseA.numSqrtPnts = numSqurePnt;
            }

            numSqurePnt++;
            lstSqurePnt.Add(new Point(x, y));

            if (numSqurePnt > 2)
            {
                lstSqurePnt.Clear();
                numSqurePnt = 0;
                imgShowLocal.Dispose();
                imgShowLocal = form_caseA.imgWork.Clone();
            }
            else if (numSqurePnt == 2)
            {
                int width = lstSqurePnt[1].X - lstSqurePnt[0].X;
                int height = lstSqurePnt[1].Y - lstSqurePnt[0].Y;

                rect = new Rect(lstSqurePnt[0].X, lstSqurePnt[0].Y, width, height);
                Cv2.Circle(imgShowLocal, new Point(x, y), circleRad, readyColor, circleThick);
                Cv2.Rectangle(imgShowLocal, rect, readyColor, rectThick, LineTypes.Link4);
            }
            else
            {
                Console.WriteLine("point number " + numSqurePnt + " - x : " + x + ", \t y : " + y);
                Cv2.Circle(imgShowLocal, new Point(x, y), circleRad, readyColor, circleThick);
            }
        }
        private void procMidBtn() {
            // copy rect object into global scope.
            form_caseA.cutRect_G = rect;
            form_caseA.numSqrtPnts = numSqurePnt;

            Cv2.Rectangle(imgShowLocal, rect, selectedColor, (rectThick + 3), LineTypes.Link4);
        }
        private void procRightBtn() {
            numSqurePnt = 0;
            lstSqurePnt.Clear();
            imgShowLocal.Dispose();

            imgShowLocal = form_caseA.imgWork.Clone();
            form_caseA.numSqrtPnts = numSqurePnt;
        }

        ~mousecallback_imgcut() {
            Console.WriteLine("imgcut mousecallback function is terminated...");
            GC.Collect();
        }
    }
}
