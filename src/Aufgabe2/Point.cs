using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2
{
    public class Point 
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            //x = x = 0 this.x = x = Wert der übergabe #2  ; y = y = 0 this.y = y = Wert
            this.x = x;
            this.y = y;
        }
        public string ToString()
        {
            return x + "," + y;
        } 
    }
}
