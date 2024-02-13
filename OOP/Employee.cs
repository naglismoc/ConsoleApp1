using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee : Citizen, INPC
    {
        public string company;
        public string occupation;


        public Employee(int id, string firstName, string lastName, int birthYear,
            bool gender, string personalCode, string citizenship, string city,
            string company, string occupation) :
            base(id, firstName, lastName, birthYear, gender, personalCode, citizenship, city)
        {
            this.company = company;
            this.occupation = occupation;
        }

        public double getDmg(int str)
        {
            Random r = new Random();
            return str * 1.15 * r.Next(0, 30);
        }

        public void makeASound()
        {
            Console.WriteLine("metodas");
        }
    }
}
