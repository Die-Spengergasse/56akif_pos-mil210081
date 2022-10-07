using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Properties
{
    public class Rechteck
    {   
        public int Laenge 
        { 
          get { return _laenge; }
          set { _laenge = value > 0 ? value : throw new ArgumentException("Ungültige Länge!"); } 
        }
        private int _laenge;

        public int Breite
        {
            get { return _breite; }
            // set { _breite = value > 0 ? value : throw new ArgumentException("Ungültige Länge!"); }
            set { _breite = value < 0 ? throw new ArgumentException("Ungültige Länge!") : value; }

        }
        private int _breite;

        // Property Flaeche ist read-only
        public int Flaeche
        {
            get { return _laenge * _breite; }
        }
    }
}
