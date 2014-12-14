using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe3
{
    public partial class Form1 : Form
    {
        const int nMax = 6;
        double newpointx = 0.0;
        double newpointy = 0.0;
        double newpoint2x = 0.0;
        double newpoint2y = 0;
        double newpoint3x = 0;
        double newpoint3y = 0;
        public Form1()
        {
            InitializeComponent();
            //
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            Point p1 = new Point(10, 300);
            Point p2 = new Point(180, 50);
            Point p3 = new Point(320, 300);
            Point p12 = new Point();
            Point p23 = new Point();
            Point p123 = new Point();
            int n = 0;
            while (n < nMax)
            {
                //erhöhe n um 1
                n++;
                //berechne drei neue Punkte
                newpointx = 0.5*(p1.X + p2.X);
                newpointy = 0.5*(p1.Y + p2.Y);
                newpoint2x = 0.5*(p2.X + p3.X);
                newpoint2y = 0.5*(p2.Y + p3.Y);
                p12 = new Point((int) newpointx, (int) newpointy);
                p23 = new Point((int) newpoint2x, (int) newpoint2y);
                newpoint3x = 0.5*(p12.X + p23.X);
                newpoint3y = 0.5*(p12.Y + p23.Y);
                p123 = new Point((int) newpoint3x, (int) newpoint3y);
                //rufe ZeichneBézier für die Punkte P1,P12,P123 sowie P123,P23,P3 auf.
                ZeichneBezier(n, p1, p12, p123, e);
                ZeichneBezier(n, p123, p23, p3, e);
            }
            //falls n == nMax: zeichne die Linien P1,P2 und P2,P3
            if (n == nMax)
            {
                Pen blackPen = new Pen(Color.Black, 2);
                e.Graphics.DrawLine(blackPen, p1, p2);
                e.Graphics.DrawLine(blackPen, p2, p3);   
            }

        }

        private void ZeichneBezier(int n, Point p1, Point p2, Point p3,PaintEventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 3);
            Point start = p1;
            Point control1 = p1;
            Point control2 = p2;
            Point end = p3;
            e.Graphics.DrawBezier(redPen, start, control1, control2, end);
        }
      
     
      
    }
}
