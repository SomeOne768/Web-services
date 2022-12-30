using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Student : Personne
    {
        public int promo { get; private set; }

        public Student(string firstName, string lastName, int promo, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.promo = promo;
            this.birthDate = birthDate;
        }

        override
        public string ToString()
        {
            return $"{firstName} {lastName} {promo} {birthDate}";
        }
    }
}
