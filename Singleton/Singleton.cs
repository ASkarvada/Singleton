using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        public Dictionary<string, Osoba> people = new Dictionary<string, Osoba>();

        private static Singleton _instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {
            people.Add("010213/0812", new Osoba("Marek", "Jarouš", "010213/0812", new DateTime(2001, 2, 13)));
            people.Add("010213/0812", new Osoba("Marek", "Jarouš", "010213/0812", new DateTime(2001, 2, 13)));
            people.Add("010213/0812", new Osoba("Marek", "Jarouš", "010213/0812", new DateTime(2001, 2, 13)));
            people.Add("010213/0812", new Osoba("Marek", "Jarouš", "010213/0812", new DateTime(2001, 2, 13)));
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
