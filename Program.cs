using System;

namespace CreateClassAAffonya
{
    class Person
    {
        private String name;
        private int birthDate;

        public Person(String name, int birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        enum Gender
        {
            Female,
            Male
        }

        public override string ToString()
        {
            return String.Format("This instance of my object has the following: name = {0}, birthDate = {1}", name, birthDate);
        }

    }
}