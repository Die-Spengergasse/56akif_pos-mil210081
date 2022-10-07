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
        public string? Zuname { get; set; }  
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
            get
            {
                if (Zuname?.Length >= 3)
                {
                    return Zuname.Substring(0, 3).ToUpper();
                }
                return "";
            } 
        }

        public decimal Nettogehalt
        {
            get { return _bruttogehalt is null ? 0 : _bruttogehalt.Value * 0.8M ; }
        }
    }
}
