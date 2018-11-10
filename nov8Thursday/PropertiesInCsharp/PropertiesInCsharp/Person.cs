using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCsharp
{
    class Person
    {
        private string _firstName;
        private string _lastName;

        private string _fullName;

        //properties of c#
        //the name of property first name
        public string firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string fullName
        {
            get
            {
                _fullName = _firstName + " " + _lastName;
                return _fullName;
            }
        }
    }
}
