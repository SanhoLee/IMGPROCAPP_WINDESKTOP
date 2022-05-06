using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace IMGPROCAPP_WINDESKTOP
{
    internal class mousecallback_imgmask
    {
        private int numPolysPnt = 0;
        private int totPolysPnt = 0;
        private List<Point> lstPolyPnts = new List<Point>();
        private List<List<Point>> lstElems = new List<List<Point>>();

        private Mat imgShowLocal = new Mat();
        private readonly string str_winMask = form_caseA.WINDOW_MASK;


        private readonly Scalar readyColor = new Scalar(255, 0, 255);
        private readonly Scalar selectedColor = new Scalar(0, 255, 0);
        private readonly int polyThick = 5;
        private readonly int circleThick = 5;
        private readonly int circleRad = 10;


        public mousecallback_imgmask()
        {
            Console.WriteLine("imgMask mousecallback function is fired...");
        }

        public void callBackFunc(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userData)
        {
            if (@event == MouseEventTypes.LButtonDown)
            {
                procLeftBtn(x, y);
            }
            else if (@event == MouseEventTypes.MButtonDown && totPolysPnt % 4 == 0)
            {   // finish status.
                procMidBtn();
            }
            else if (@event == MouseEventTypes.RButtonDown)
            {   // reset status.
                procRightBtn();
            }

            // show working img anyway...
            if (!imgShowLocal.Empty())
            {
                Cv2.ImShow(str_winMask, imgShowLocal);
            }
        }

        private void procLeftBtn(int x, int y)
        {
            if (totPolysPnt == 0)
            {
                imgShowLocal = form_caseA.imgWork.Clone();
                form_caseA.numPolyPnts = numPolysPnt;
            }

            numPolysPnt++;
            totPolysPnt++;
            lstPolyPnts.Add(new Point(x, y));

            if (numPolysPnt == 4 )
            {
                Cv2.Circle(imgShowLocal, new Point(x, y), circleRad, readyColor, circleThick);
                Cv2.Polylines(imgShowLocal, InputArray.Create(lstPolyPnts), true, readyColor, polyThick, LineTypes.Link4);

                lstElems.Add(new List<Point>(lstPolyPnts));
                lstPolyPnts.Clear();
                numPolysPnt = 0;
            }
            else
            {
                Console.WriteLine("point number " + numPolysPnt + " - x : " + x + ", \t y : " + y);
                Cv2.Circle(imgShowLocal, new Point(x, y), circleRad, readyColor, circleThick);
            }
        }

        private void procMidBtn()
        {
            // copy the points list into global scope.
            form_caseA.lstPolyElems.AddRange(new List<List<Point>>(lstElems));

            for(int i = 0; i < lstElems.Count; i++)
            {
                Cv2.Polylines(imgShowLocal, InputArray.Create(lstElems[i]), true, selectedColor, polyThick, LineTypes.Link4);
            }
        }


        private void procRightBtn()
        {
            totPolysPnt = 0;
            numPolysPnt = 0;
            lstElems.Clear();
            form_caseA.lstPolyPnts.Clear();
            form_caseA.lstPolyElems.Clear();
            imgShowLocal.Dispose();

            imgShowLocal = form_caseA.imgWork.Clone();
            form_caseA.numPolyPnts = numPolysPnt;
        }

        ~mousecallback_imgmask()
        {
            Console.WriteLine("imgmask mousecallback function is terminated...");
            GC.Collect();
        }
    }
}
