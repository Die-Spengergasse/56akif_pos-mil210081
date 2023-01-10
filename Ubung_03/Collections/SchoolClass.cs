// See https://aka.ms/new-console-template for more information
using ExCollection.App;

namespace ExCollection.App
{
    public class SchoolClass
    {
        // TODO: Erstelle ein Property Schuelers, welches alle Schüler der Klasse in einer
        //       Liste speichert.
        public string Name { get; set; } = string.Empty;
        public string KV { get; set; } = string.Empty; 
        public List<Student> Schuelers { get; set; } = new List<Student>();

        /// <summary>
        /// Fügt den Schüler zur Liste hinzu und setzt das Property KlasseNavigation
        /// des Schülers korrekt auf die aktuelle Instanz.
        /// </summary>
        /// <param name="s"></param>
        public void AddSchueler(Student s)
        {
            // ist der Schueler NULL 
            if (s is null)
            {
                throw new ArgumentNullException("Schueler ist null");
            }

            // Gibt es den Schueler bereits in der Liste
            if (Schuelers.Contains(s))
            { 
                throw new Exception("Schueler ist bereits in der Klasse"); 
            }

            s.KlasseNavigation = this; // muss, anders fall bleibt die Klasse immer null 
            Schuelers.Add(s);
        }
    }
}

