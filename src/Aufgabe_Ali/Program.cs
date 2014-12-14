using System;
using System.Collections;

namespace Aufgabe1
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Auffordern der Eingabe eines Ausdrucksstrings
            Console.Write("Ausdruck eingeben:");
            //Übergabe des eingegebenen Strings aus der Console in eine variable m_ausdruck
            string m_ausdruck = Console.ReadLine();
            //Aufrufen der funktion KlammerPruefung um zu schauen ob der Ausdruck i.O ist oder nicht.
            KlammerPruefung(m_ausdruck);
            Console.ReadKey();
        }

        private static void KlammerPruefung(string ausdruck)
        {
            //Einen stack instanzieren.
            Stack stack = new Stack();
          
            // Wir iterieren durch den Ausdruck um die richtige Klammertiefe herausfinden
            for (int i = 0; i < ausdruck.Length; i++)
            {
                if (ausdruck[i] == '(')
                {
                    stack.Push(ausdruck[i]);
                }
                if (ausdruck[i] == ')')
                    stack.Pop();
            }
            if (stack.Count != 0)
            {
                Console.WriteLine("Fehler der Ausdruck ist nicht richtig die Klammern wurden nicht richtig geschlossen!");
            }
            else
            {
                Console.WriteLine("Der Ausdruck ist richtig! ");
            }
        }

    }


}

