using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Properties
{
    public class Lehrer
    {
        public string Zuname { get; set; } = string.Empty;
        public string Vorname { get; set; } = string.Empty;
        public decimal? Bruttogehalt 
        {
            get { return _bruttogehalt; }
            set
            {
                _bruttogehalt ??= value; 
            }
        }
        private decimal? _bruttogehalt;

        public string Kuerzel
        {
            get { return Zuname?.Substring(0,3)?.ToUpper() ?? " "; }
        }

        public decimal Nettogehalt
        {
            get { return _bruttogehalt ?? 0 * 0.8M; }
        }
    }
}
