// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;
using ExCollection.App;
using Newtonsoft.Json;

namespace ExCollection.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SchoolClass> schoolClasses = new Dictionary<string, SchoolClass>();
            schoolClasses.Add("3AHIF", new SchoolClass() { Name = "3AHIF", KV = "KV1" });
            schoolClasses.Add("3BHIF", new SchoolClass() { Name = "3BHIF", KV = "KV2" });
            schoolClasses.Add("3CHIF", new SchoolClass() { Name = "3CHIF", KV = "KV3" });
            schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1001, FirstName = "VN1", LastName = "ZN1", MaximaleStudiendauer = 5 });
            schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1002, FirstName = "VN2", LastName = "ZN2", MaximaleStudiendauer = 2 });
            schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1003, FirstName = "VN3", LastName = "ZN3", MaximaleStudiendauer = 2 });
            schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1011, FirstName = "VN4", LastName = "ZN4", MaximaleStudiendauer = 2 });
            schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1012, FirstName = "VN5", LastName = "ZN5", MaximaleStudiendauer = 2 });
            schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1013, FirstName = "VN6", LastName = "ZN6", MaximaleStudiendauer = 7 });
            schoolClasses["3CHIF"].AddSchueler(new Student() { Id = 1021, FirstName = "VN7", LastName = "ZN7", MaximaleStudiendauer = 7 });
           // schoolClasses["3CHIF"].AddSchueler(new Teacher() { Id = 1021, FirstName = "VN7", LastName = "ZN7"});


            Student s = schoolClasses["3AHIF"].Schuelers[0];
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
            Console.WriteLine("3AHIF vor ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(schoolClasses["3AHIF"].Schuelers));
            s.ChangeKlasse(schoolClasses["3BHIF"]);
            Console.WriteLine("3AHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(schoolClasses["3AHIF"].Schuelers));
            Console.WriteLine("3BHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(schoolClasses["3BHIF"].Schuelers));
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");

            KuerzesteStudienDauer(schoolClasses["3AHIF"]);

            Console.WriteLine(schoolClasses["3AHIF"].Schuelers[0].FullName); // Lehrer wird nicht aufgenommen
        }

        private static void KuerzesteStudienDauer(SchoolClass k)
        {
            // 0. Initialisierung mit Maximalwert
            // ODER // 1. erste Dauer merken
            // 2. Pruefung ob die naechste Dauer kleiner oder groeser ist
            // 2.1 Wenn groesser: nicht zu tun; zum naechsten Schueler gehen
            // 2.2 Wenn kleiner: ueberscreiben wir den ersten Wert mit dem neuen Minimum 

            int minWert = 7;
            foreach (Student item in k.Schuelers)
            {
                if (item.MaximaleStudiendauer < minWert)
                {
                    if(item is Student)
                    {
                        minWert = item.MaximaleStudiendauer;
                    }
                }
            }
            Console.WriteLine($"Miminale Studiendauer un dieser Klasse {k?.Name ?? "unbekannt"} ist: {minWert}");
        }


    }

    public class GalerijaStudent
    {
        public Dictionary<string, List<Student>> kolekcije = new Dictionary<string, List<Student>>();

        public void AddToCollection(string imeKolekcije, Student s)  // dodaje ImagePost ip u zadatu kolekciju
        {
            kolekcije[imeKolekcije].Add(s);
        }

        public int StudentCount(string imeKolekcije)  // izbrojim koliko je ImagePostova u nekoj kolekciji
        {
            return kolekcije[imeKolekcije].Count;
        }

        public Dictionary<string, List<Person>> kolekcijaPostova = new Dictionary<string, List<Person>>();  // kljuc - vrednost
        public int StudentCount1(string imeKolekcije)  // izbrojim koliko je ImagePostova u nekoj kolekciji
        {
            // return kolekcijaPostova[imeKolekcije].Count(post => post is ImagePost);

            int num = 0;
            foreach (Person p in kolekcijaPostova[imeKolekcije])
            {
                if (p is Student) 
                {
                    num++;
                }
            }

            // kolekcijaPostova.Keys.Contains(imeKolekcije); // vraca true / false

            return num;
        }
    }
}


