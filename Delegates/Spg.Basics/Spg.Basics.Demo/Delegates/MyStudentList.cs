using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Basics.Demo.Delegates
{
    // UVEK moram da nekako obezbedim ulazni parametar delegata
    // ovde mi ulazni parametar delegata dolazi iz foreach-a
    // public delegate bool FilterHandler(Student s); // hocu da mogu da filtriram i po LastName, FirstName, BirthDate...

    public class MyStudentList : List<Student>
    {
        public MyStudentList Filter(Func<Student, bool> predicate)
        {
            MyStudentList resultatFunkcijeFilter = new MyStudentList();

            foreach (Student item in this)
            {
                if (predicate(item)) // ulazni parametar na osnovu ulaznog parametra delegata
                {
                    resultatFunkcijeFilter.Add(item);
                }
            }
            return resultatFunkcijeFilter; 
        }

        /*
        public List<Student> Filter(string partOfLastName)
        {
            List<Student> list = new List<Student>();

            foreach (Student item in this)
            {
                if (item.LastName.Contains(partOfLastName))
                { 
                    list.Add(item);
                }
            }
            return list;
        }
        */
    }
}
