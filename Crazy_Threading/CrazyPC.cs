using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Crazy_Threading
{
    internal class CrazyPC
    {
        public static Random _random = new Random();

        public static void CrazyFunctionCall()
        {
            Thread crazyMouseThread = new Thread(new ThreadStart(CrazyMouseThread));
            Thread crazyKeyboardthread = new Thread(new ThreadStart(CrazyKeyboardThread));

            crazyMouseThread.Start();
            crazyKeyboardthread.Start();
        }

        static void CrazyMouseThread()
        {
            Trace.WriteLine("Crazy Mouse Start");

            int moveX = 0;
            int moveY = 0;

            while (true) 
            {
                moveX = _random.Next(30) - 15;
                moveY = _random.Next(30) - 15;

                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);
                Thread.Sleep(100);
            }
        }

        static void CrazyKeyboardThread()
        {
            Trace.WriteLine("Crazy Keyboard Thread Started");\

            while (true) 
            {
                // Create Random Character Key
                char key = (char)(_random.Next(50) + 45);

                if (_random.Next(2) == 0)
                {
                    key = char.ToLower(key);
                }

                try
                {
                    SendKeys.SendWait(key.ToString());
                }
                catch 
                {
                    Trace.
                }

                //SendKeys.SendWait(key.ToString());
                SendKeys.SendWait(key.ToString());
                Thread.Sleep(500);
            
            }


        }

        public static void freddiekreuger()
        { 
            
        }

    }
}
