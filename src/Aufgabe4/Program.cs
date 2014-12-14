using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s.Equals("game.exe < maze.dat"))
                Application.Run(new Labyrinth());       
        }
    }
}
