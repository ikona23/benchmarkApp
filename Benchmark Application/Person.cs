using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benchmark_Application
{
    public class Person
    {
        private int age;
        private string firstname;
        private string lastname;
        /// <summary>
        /// Constructor for the first class
        /// </summary>
        public Person()
        {
            firstname = "unknown";
            lastname = "unknown";
            age = 10;
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Overrides the method Tostring() that already exists
        /// </summary>
        /// <returns>The first name and the Last name with a space inbetween</returns>
        public override string ToString()
        {
            return firstname + " " + lastname;
        }
    }
}
