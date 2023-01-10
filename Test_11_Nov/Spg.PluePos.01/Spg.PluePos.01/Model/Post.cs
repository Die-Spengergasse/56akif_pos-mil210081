using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public abstract class Post
    {
        public string Title { get; } // oder private setter 

        public DateTime Created { get; }

        public int Rating 
        { 
            get { return _rating; }
            
            set
            {
                if (value >= 1 && value <= 5)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Range muss zwischen 1 und 5 liegen!");
                }
            }
        }
        private int _rating;

        public abstract string Html { get; }

        public SmartPhoneApp? SmartPhone { get; set; } // = new(); ne sme tako jel ce da baci gresku jer nema parametar koji je definisan u konstruktoru
        // sa  = new("braucht Parameter"); radice

        // Konstruktor
        protected Post(string title, DateTime created)
        {
            if (title == null)
            {
                throw new ArgumentNullException("Titel war NULL");
            }
            Title = title;
            Created = created;
        }

        public Post(string title) : this(title, DateTime.Now) // this pokazuje na konstr. iznad
        {
        }

        public override string ToString()
        {
            return Html;
        }
    }
}
