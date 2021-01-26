using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    
    public class Osoba
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public Osoba(string name, string surname, string birthNumber, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthNumber = birthNumber;
            BirthDate = birthDate;
        }

        
    }
    
}
