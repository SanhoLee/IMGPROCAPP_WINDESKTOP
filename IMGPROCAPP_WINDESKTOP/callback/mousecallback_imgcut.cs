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

        public mousecallback_imgcut() {
            Console.WriteLine("imgcut mousecallback function is fired...");
        
        
        }

        public void callBackFunc(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userData)
        {
            if (@event == MouseEventTypes.LButtonDown) {

                Console.WriteLine("x : " + x + ", \t y : " + y);
            
            }else if(@event == MouseEventTypes.LButtonUp) {
            
            
            
            
            }else if(@event == MouseEventTypes.RButtonDown) {
            
            
            
            
            }


        }

        ~mousecallback_imgcut() {
            Console.WriteLine("imgcut mousecallback function is terminated...");
            GC.Collect();
        }
    }
}
