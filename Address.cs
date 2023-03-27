using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Address
    {
        public Address(string name, string secondName, string surname, string street, string city, string province, string zip )
        {
            Name = (name != "") ? name : "Non assegnato";
            SecondName = (secondName != "") ? secondName : "Non assegnato";
            Surname = (surname != "") ? surname : "Non assegnato";
            Street = (street != "") ? street : "Non assegnato";
            City = (city != "") ? city : "Non assegnato";
            Province = (province != "") ? province : "Non assegnato";
            Zip = zip ?? "Non assegnato";
        }
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }
    }
}
