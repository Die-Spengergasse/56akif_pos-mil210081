// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using ExCollection.App;

namespace ExCollection.App
{
    public class Student : Person 
    {
        // TODO: Erstelle ein Proeprty KlasseNavigation vom Typ Klasse, welches auf
        //       die Klasse des Schülers zeigt.
        // Füge dann über das Proeprty die Zeile
        // [JsonIgnore]
        // ein, damit der JSON Serializer das Objekt ausgeben kann.
       
        public int Id { get; set; } 
        public string LastName { get; set; } = string.Empty; 
        public string FirstName { get; set; } = string.Empty;

        public string FullName 
        {
            get
            {
                /*
                StringBuilder s = new StringBuilder();
                s.Append("");
                s.Append("");
                */
                return $"Full Name: {FirstName} {LastName}";
            }
        }
        // private string _fullName;

        public int MaximaleStudiendauer
        {
            get { return _maximaleStudiendauer; }
            set
            {
                if (value >= 1 && value <= 7)
                {
                    _maximaleStudiendauer = value;
                }
                else
                {
                    throw new ArgumentException("Studiendauer ");
                }
            }
        }
        private int _maximaleStudiendauer;
 

        [JsonIgnore] // ignoriere mir den Rest
        public SchoolClass KlasseNavigation { get; set; } = new SchoolClass();

        /// <summary>
        /// Ändert die Klassenzugehörigkeit, indem der Schüler
        /// aus der alten Klasse, die in KlasseNavigation gespeichert ist, entfernt wird.
        /// Danach wird der Schüler in die neue Klasse mit der korrekten Navigation eingefügt.
        /// </summary>
        /// <param name="k"></param>
        public void ChangeKlasse(SchoolClass k)
        {
            if (k is null)
            {
                throw new ArgumentNullException("Schueler ist null");
            }

            this.KlasseNavigation.Schuelers.Remove(this);
            k.Schuelers.Add(this);
            this.KlasseNavigation = k;
            // k.AddSchueler(this);
        }

        public override string GetArriveType()
        {
            return "Reist maist oeffentlich an, oder mit dem Fahrrad.";
        }
    }
}

