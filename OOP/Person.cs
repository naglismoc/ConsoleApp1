using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person : Object
    {
        public int id { get; set; }
        private string firstName;
        public string lastName;
        public int birthYear;
        public bool gender;

        public Person()
        {
        }
        public Person(string firstName, string lastName, int birthYear, bool gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.gender = gender;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = formatName(value); }
        }
        private string formatName(string name)
        {
            return name.Trim().Substring(0, 1).ToUpper() + name.Trim().Substring(1).ToLower();
        }

        public string getFirstName()
        {
            return this.firstName;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName.Trim();
        }

        public virtual void whoAmI()
        {
            Console.WriteLine("As esu Person");
        }
        public string info()
        {
            return $"Sveiki, aš esu {this.firstName} {this.lastName}." +
                    " Aš esu " + ((this.gender) ? "vyras" : "moteris") +
                    $". gimiau {this.birthYear} metais.";
        }
        public int getAge()
        {
            return DateTime.Now.Year - this.birthYear;
        }

        public override string? ToString()
        {
            return $"Sveiki, aš esu {this.firstName} {this.lastName}." +
                    " Aš esu " + ((this.gender) ? "vyras" : "moteris") +
                    $". gimiau {this.birthYear} metais.";
        }

        public static void classIntro()
        {
            Console.WriteLine("Sita klase skirta kurti Person objektams");
        }
    }
}
