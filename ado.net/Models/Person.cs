using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ado.net.Models
{
    public class Person
    {
        int id;
        public string firstName { get; set; }
        public string lastName;
        public string email;
        public DateTime dateBirth;
        public string image;
        public string country;
        public Person(int id, string firstName, string lastName, string email,DateTime dateBirth, string image, string country)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dateBirth = dateBirth;
            this.image = image;
            this.country = country;
        }
    }
}