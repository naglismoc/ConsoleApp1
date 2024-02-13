using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Citizen : Person
    {
        public string personalCode;
        public string citizenship;
        public string city;

        public Citizen()
        {
        }
        public Citizen(string personalCode, string citizenship, string city)
        {
            this.personalCode = personalCode;
            this.citizenship = citizenship;
            this.city = city;
        }

        public Citizen(int id, string firstName, string lastName, int birthYear, bool gender, string personalCode, string citizenship, string city) : base(firstName, lastName, birthYear, gender)
        {
            this.personalCode = personalCode;
            this.citizenship = citizenship;
            this.city = city;
        }
        public override void whoAmI()
        {
            Console.WriteLine("As esu Citizen");
        }
        public override string? ToString()
        {
            return base.ToString() + $" Esu {citizenship}, gyvenu {city}, mano asmens kodas {personalCode}";
        }
    }
}
