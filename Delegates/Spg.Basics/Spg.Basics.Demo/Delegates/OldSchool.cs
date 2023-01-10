using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Basics.Demo.Delegates
{
    // public delegate bool CompareHandler(int a, int b); // Delegate hat keine Logik

    /*
    public class OldSchool
    {
        // INVERSION OF CONTROLL (Umkehrung der Kontrolle) - Pattern
        // ich moechte NICHT die Methode aendern
        // UVEK moram da nekako obezbedim ulazni parametar delegata
        public bool GreatMethodForNearlyEverything(CompareHandler handler, int x, int y)
        {
            // ...
            // 1000 Zeilen Code (z.B. irgendweche Vorbereitungen werden duhgeführt)
            // ...

            // tek ovde pozivam funkciju 
            bool result = handler(x, y); // ist musste die alte Methode (CompareEqual) ersetzen 

            if (result == true)
            {
                // Do something
            }
            else
            {
                // Do something else
            }

            // ...
            // 1000 Zeilen Code (z.B. result wird irgendwie verarbeitet)
            // ...

            return result;
        }

        public bool CompareEqual(int x, int y)
        {
            return (x == y);    // returns true oder false
        }

        public bool CompareGreater(int x, int y)
        { 
            return(x > y);
        }

        public void DoSomeWork()
        {
            Console.WriteLine(GreatMethodForNearlyEverything(CompareGreater, 5, 12)); 
        }

    }
    */


    public class OldSchool
    {
        public delegate bool CompareHandler(int x, int y); 

        /// <summary>
        /// Diese Methode hat den Nachteil, dass der Vergleich fix gecodet ist.
        /// Möchte ich auf != vergleichen, muss ich die Methode ändern.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool GreatMethodForNearlyEverything(CompareHandler predicate, int x, int y)
        {
            // ...
            // 1000 Zeilen Code (z.B. irgendweche Vorbereitungen werden duhgeführt)
            // ...

            bool result = predicate(x, y);

            // ...
            // 1000 Zeilen Code (z.B. result wird irgendwie verarbeitet)
            // ...

            return result;
        }

        public bool CompareEqual(int x, int y)
        {
            return (x == y);
        }
        public bool CompareNotEqual(int x, int y)
        {
            return (x != y);
        }

        public void DoSomeWork()
        {
            bool result = GreatMethodForNearlyEverything(CompareEqual, 5, 5);

            Console.WriteLine(result);
        }
    }



}
