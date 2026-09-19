using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace CosmosMotor
{
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void Points(int x, int y)
        {


            Pen p = new Pen(Color.FromArgb(0, 0, 0));
            canvas.DrawPoint(p, x, y);





        }

        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1020;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                graf.starts();
                graf.cls(Color.White);
                while (true)
                {
                    Thread.Sleep(200);

                    tests.mainLoop();



                    ;

                }
            }


        }
    }





    class tests



    {

        static int value=0;
        public static void mainLoop()
        {
            //


            Pen p = new Pen(Color.Black, 1);
            graf.canvas.Clear(Color.White);

            double v = Math.PI / 11.00 * ((double)value);
            double rrr = 100.00;
           
            Pen a = new Pen(Color.FromArgb(0, 0, 0));
            Pen c = new Pen(Color.FromArgb(255, 255, 255));
            ;
            
            

            graf.canvas.DrawEllipse(a, new Sys.Graphics.Point(((int)rrr)+119, ((int)rrr)+119), 60, 60);
            graf.canvas.DrawEllipse(a, new Sys.Graphics.Point(((int)rrr) + 20 - ((int)(Math.Sin(v) * rrr))+100, ((int)rrr) + 20 + ((int)(Math.Cos(v) * rrr))+100), 30, 30);
            value++;
            if (value > 21) value = 0;
            graf.canvas.Display();



        }

    }






}
