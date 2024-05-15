using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXUnitProjekt
{
    public class NameRegister
    {
        public string FullName(string firstName,  string lastName) {
            return firstName + " " + lastName;
        }

        public string StandardizedName(string firstName, string lastName)
        {
            firstName = firstName.ToLower();
            lastName = lastName.ToLower();
            return firstName + " " + lastName;
        }

        public NameRegister createNew(bool person)
        {
            if (person)
            {
                return new Person();
            }
            else {
                return new NameRegister();
            }
        }
    }
}
