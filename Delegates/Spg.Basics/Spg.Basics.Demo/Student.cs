using System.ComponentModel.DataAnnotations;

namespace Spg.Basics.Demo
{
    public partial class Student : Person
    {
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{FirstName} - {LastName} - {BirthDate}";
        }

    }
}
