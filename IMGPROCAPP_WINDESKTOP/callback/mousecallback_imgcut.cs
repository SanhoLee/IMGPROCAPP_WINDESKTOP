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

        



        public mousecallback_imgcut() {
            Console.WriteLine("imgcut mousecallback function is fired...");
        }

        public void callBackFunc(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userData)
        {
            if (@event == MouseEventTypes.LButtonDown) {
                if (numSqurePnt == 0)
                {
                    imgShowLocal = form_caseA.imgWork.Clone();
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
                else if (numSqurePnt == 2) {
                    int width = lstSqurePnt[1].X - lstSqurePnt[0].X;
                    int height = lstSqurePnt[1].Y - lstSqurePnt[0].Y;

                    rect = new Rect(lstSqurePnt[0].X, lstSqurePnt[0].Y, width, height);
                    Cv2.Circle(imgShowLocal, new Point(x, y), 10, new Scalar(200, 0, 0), 3);
                    Cv2.Rectangle(imgShowLocal, rect, new Scalar(0, 0, 255), 10, LineTypes.Link4);
                }
                else
                {
                    Console.WriteLine("point number " + numSqurePnt + " - x : " + x + ", \t y : " + y);
                    Cv2.Circle(imgShowLocal, new Point(x, y), 10, new Scalar(200, 0, 0), 3);
                }

                Cv2.ImShow(str_winCut, imgShowLocal);
            
            }else if(@event == MouseEventTypes.MButtonDown) {   // finish status.
                Cv2.Rectangle(imgShowLocal, rect, new Scalar(0, 255, 0), 12, LineTypes.Link4);
                Cv2.ImShow(str_winCut, imgShowLocal);

                // copy rect object into global scope.
                form_caseA.cutRect_G = rect;
            }
            else if(@event == MouseEventTypes.RButtonDown) {   // reset status.
                numSqurePnt = 0;
                lstSqurePnt.Clear();
                imgShowLocal.Dispose();

                imgShowLocal = form_caseA.imgWork.Clone();
                Cv2.ImShow(str_winCut, imgShowLocal);
            }


        }

        ~mousecallback_imgcut() {
            Console.WriteLine("imgcut mousecallback function is terminated...");
            GC.Collect();
        }
    }
}
