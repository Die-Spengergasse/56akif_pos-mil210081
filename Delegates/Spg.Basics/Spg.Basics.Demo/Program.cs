// See https://aka.ms/new-console-template for more information
using Spg.Basics.Demo;
using Spg.Basics.Demo.Delegates;
using System.Globalization;
using System.Reflection;

Console.WriteLine("Hello, World!");

string s = "My first String";

Console.WriteLine(s);

Person person = new Person();
person.Id = 4711;
person.FirstName = "";
person.LastName = "Schrutek2";
person.Gender = Genders.Male;

string x = person?.FirstName ?? "noName";


if (person is Student)
{
    Console.WriteLine("Objekt ist Student!");
}
else if (person is Teacher)
{
    Console.WriteLine("Objekt ist Lehrer!");
}

var fullName= person?.GetType().GetMethods() ?? new MethodInfo[0];

int i = new int();
i = 5;

Console.WriteLine("Hello" + " " + "World!");
Console.WriteLine("C:\\temp\\databases\\mydb.db");
Console.WriteLine(@"C:\temp\databases\mydb.db");
Console.WriteLine($@"Name: {person?.FirstName ?? ""} - {person?.LastName ?? ""} ; Path: C:\temp\databases\mydb.db");
Console.WriteLine(string.Format(new CultureInfo("en-US"), "Datum: {0:dd/MM/yyyy}, {1}", DateTime.Now, "asdasdasdasd"));

Nullable<int> a = 12;
if (a.HasValue)
{
    Console.WriteLine(a.Value);
}
else
{
    Console.WriteLine("");
}
Console.WriteLine(a?.ToString() ?? "");

Console.WriteLine(a.HasValue ? a.Value : ""); // das gleiche wie in Java (if-Kurzschreibweise)

// string eingabe = Console.In.ReadLine();

// Parse:


int eingabeConverted; // = int.Parse(eingabe);

/*
if (!int.TryParse(eingabe, out eingabeConverted))
{
    Console.WriteLine("Keine Zahl!!!");
}
*/

// Console.WriteLine(eingabeConverted);


SchoolClass schoolClass = new SchoolClass() { Name = "", MaxStudents = 32 };

List<SchoolClass> schoolClasses = new List<SchoolClass>()
{
    new SchoolClass() {  MaxStudents=10, Name="" },
    new SchoolClass() {  MaxStudents=8, Name="", 
        Students= new List<Student>()
        {
            new Student() { },
            new Student() { },
            new Student() { },
            new Student() { },
        }
    },
    new SchoolClass() {  MaxStudents=10, Name="" },
    new SchoolClass() {  MaxStudents=10, Name="" },
    new SchoolClass() { MaxStudents=12, Name="" }
};

schoolClasses[1].Name = "5AKIF";
schoolClasses[1].Students.ElementAt(2).FirstName = "Martin";


schoolClass.Name = "5AKIF";
//schoolClass.MaxStudents = 32;

Console.WriteLine(schoolClass.Name);

MyStudentList students = new MyStudentList()    // Liste
{
    new Student() {FirstName = "First01", LastName = "ALast01", BirthDate = new DateTime(2008,05,03)},
    new Student() {FirstName = "First02", LastName = "ALast01", BirthDate = new DateTime(1977,12,01)},
    new Student() {FirstName = "First03", LastName = "BLast01", BirthDate = new DateTime(2008,06,03)},
    new Student() {FirstName = "First04", LastName = "CLast01", BirthDate = new DateTime(1991,02,25)},
    new Student() {FirstName = "First10", LastName = "ALast10", BirthDate = new DateTime(1999,11,28)},
    new Student() {FirstName = "First11", LastName = "CLast11", BirthDate = new DateTime(2008,04,30)},
};

/*
MyStudentList results = students.
    Filter(BirthDateBefore2000).
    Filter(LastNameContainsA);
*/

MyStudentList results = students
    .Filter(s => s.BirthDate < new DateTime(2000, 01, 01))
    .Filter(s => s.LastName.Contains("A"));

foreach (Student item in results)
{
    Console.WriteLine(item.ToString());
}


Console.WriteLine("----------------------");
OldSchool oldschool = new OldSchool(); // vraca false za resultat

oldschool.DoSomeWork();

/*
bool LastNameContainsA(Student s)
{
    return s.LastName.Contains("A") ; // vraca true ili false
}

bool BirthDateBefore2000(Student s)
{
    return s.BirthDate < new DateTime(2000,01,01); // vraca true ili false

*/