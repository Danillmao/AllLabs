using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    internal class Person
    {
        string _firstName;
        string _lastName;
        DateTime _birthdate;
        public Person(string firstName, string lastName, DateTime birthdate) //Класс с параметрами.
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthdate = birthdate;
        }
        public Person() : this("Firstname", "LastName", new DateTime(2022, 12, 1)) //Класс без параметров.
        {

        }
      
        string FirstName
        {
            get { return _firstName; }
        }
        string LastName
        {
            get { return _lastName; }
        }
        DateTime Birthdate
        {
            get { return _birthdate; }
        }

        int Bdate
        {
            get
            {
                return Convert.ToInt32(_birthdate);
            }
            set
            {
               _birthdate = Convert.ToDateTime(value);
            }
        }

       public string ToFullString() 
        { 
            return _firstName + " " + _lastName + "" + _birthdate;
        }

        public string ToShortString()
        {
            return _firstName + "" + _lastName;
        }
    }
}