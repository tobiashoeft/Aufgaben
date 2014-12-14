using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe4
{
    public partial class Labyrinth : Form
    {

        private static int _Rows;
        private static int _Columns;
        private static Dictionary<Point, string> maze_Elements;
        private static Dictionary<Point, string> items;
        private static Dictionary<Point, string> game_figur;

        public Labyrinth()
        {
            InitializeComponent();
            Graphics dc = this.CreateGraphics();
            this.Show();
            CreateMaze(dc);
        }

        private void CreateMaze(Graphics dc)
        {
            maze_Elements = new Dictionary<Point, string>();
            items = new Dictionary<Point, string>();
            game_figur = new Dictionary<Point, string>();

            string[] lines = File.ReadAllLines("maze.dat");
            _Columns = int.Parse(lines[0]);
            _Rows = int.Parse(lines[1]);
            int helper = 0;
            for (int i = 2; i < lines.Count(); i++)
            {
                helper = 0;
                var s = lines[i].ToCharArray(0, lines[i].Count());
                foreach (char c in s)
                {
                    helper++;
                    if (c.Equals('#'))
                    {
                        Point p_maze = new Point(helper * 20, i * 20);
                        maze_Elements.Add(p_maze, "#");
                        dc.DrawString(c.ToString(), new Font("Arial", 20), Brushes.Green, p_maze);
                    }
                    //Middledot  "\u00B7"
                    else if (c.Equals('.'))
                    {
                        Point p_items = new Point(helper * 20, i * 20);
                        items.Add(p_items, "\u00B7");

                        dc.DrawString("\u00B7", new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel),
                            Brushes.Blue, p_items);
                    }
                    else if (c.Equals(' '))
                    {
                        Point p_gamefigur = new Point(helper * 20, i * 20);
                        game_figur.Add(p_gamefigur, "@");
                        dc.DrawString("@", new Font("Arial", 14), Brushes.Red, p_gamefigur);
                    }
                }
            }
        }

        private void Labyrinth_Load(object sender, EventArgs e)
        {
          
        }

        protected override void OnPaint(PaintEventArgs e)
        {
         


        }





    }
}



 

