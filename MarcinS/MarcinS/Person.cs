using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MarcinS
{
    [XmlRoot(ElementName = "Osoby")]
    public class Person
    {
        [XmlAttribute("pesel")]
        public string pesel { get; set; }
        [XmlAttribute("firstName")]
        public string firstName { get; set; }
        [XmlAttribute("lastName")]
        public string lastName { get; set; }
        [XmlAttribute("age")]
        public string age { get; set; }

        public Person()
        {

        }
        public Person(string pesel, string firstName, string lastName, string age)
        {
            this.pesel = pesel;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Person(Person osoba)
        {
            this.pesel = osoba.pesel;
            this.firstName = osoba.firstName;
            this.lastName = osoba.lastName;
            this.age = osoba.age;
        }
    }
}
