using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAgeException
{
    public class PersonAge
    {
        public int age;

        public PersonAge(int age)
        {
            this.age = age;
        }

        public string GetAge()
        {
            try
            {
                if (age >= 1 && age <= 14)
                {
                    return "Children";
                }
                else if (age >= 15 && age <= 24)
                {
                    return "Youths";
                }
                else if (age >= 25 && age <= 64)
                {
                    return "Adults";
                }
                else if (age >= 65 && age <= 120)
                {
                    return "Seniors";
                }
                else
                {
                    return default;
                }
            }
            catch (NullReferenceException)
            {

                throw new PersonAgeCustomeException(PersonAgeCustomeException.ExceptionType.NullMessage,"Age cannot be null");
            }
        }
    }
}
