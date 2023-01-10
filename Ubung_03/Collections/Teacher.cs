using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ExCollection.App;

namespace ExCollection.App
{
    internal class Teacher : Person
    {
        public override string GetArriveType()
        {
            return "Resit meist mit dem Auto";
        }

        // private string _fullName = string.Empty;

        public string FullName 
        {
            get 
            { 
                return $"Full Name: {LastName } - {FirstName } (Teacher)"; // Info: das ist ein Teacher
            } 
       }

    }
}
