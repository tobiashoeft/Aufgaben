using System;
using System.Collections;
using System.Collections.Generic;

namespace Aufgabe2
{
    class Program
    {
        class PointComparer : IComparer
        {
          
            public int Compare(object p1, object p2)
            {
                Point _p1 = (Point) p1;
                Point _p2 = (Point) p2;
                if (_p1.y < _p2.y || _p1.y == _p2.y)
                {
                    return _p1.x - _p2.x;
                }
                else
                {
                    return _p1.y - _p2.y;
                }

            }
        }

        public static void Main(string[] args)
        {
            ArrayList AL = new ArrayList();
            Random R = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                Point p = new Point(R.Next(50), R.Next(50));
                AL.Add(p);
            }
            
            PrintValues(AL);
            IComparer comparer = new PointComparer();
            
            //Mit dem normalen Sort() schmeißt er eine InvalidOperationException Fehler beim Vergleichen von zwei Elementen im Array(Falscher Typ): 
            //AL.Sort();
            //Lösung für die Aufgabe einen eigenen PointComparer schreiben der abgeleitet von IComparer ist. Dort die gewünschten "Vergleichsoperatoren" erfassen.
            AL.Sort(comparer);
            PrintValues(AL);
            Console.ReadLine();
        }
      
    

        public static void PrintValues(IEnumerable myList)
        {
            //Point nicht Obj und dann den Point.ToString() aus der Klasse Point.cs  #1
            foreach (Point point in myList)
                Console.WriteLine("{0}", point.ToString());
            Console.WriteLine();
        }
    }
}

