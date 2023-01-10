using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCollection.App;

namespace ExCollection.App
{
    public abstract class Person 
    {
        public int Id { get; set; }

        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;

        public string FullName
        {
            get
            {
                return $"Full Name: {FirstName} {LastName}";
            }
        }

        public abstract string GetArriveType();
    }
}
