using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Benchmark_Application
{
    class FileManager
    {
        public List<Person> LoadPeople()
        {
            List<Person> thePeople = new List<Person>();

            StreamReader sr = new StreamReader("Person.txt");

            while (!sr.EndOfStream)
            {
                string temp = sr.ReadLine();

                string[] tempAr = temp.Split(' ');

                Person aPerson = new Person();

                aPerson.Firstname = tempAr[0];
                aPerson.Lastname = tempAr[1];

                thePeople.Add(aPerson);
            }

            sr.Close();

            return thePeople;
        }

        public void SavePerson(Person thePerson)
        {
        string fileName = thePerson.Firstname + thePerson.Lastname + ".html";

        StreamWriter sw = new StreamWriter(fileName, false);

        sw.WriteLine("<html>");
        sw.WriteLine("<head><title>Saved Person</title><head>");
        sw.WriteLine("<body>");
        sw.WriteLine("<h2>" + thePerson.Firstname + "</h2>");
        sw.WriteLine("<h2>" + thePerson.Lastname + "</h2>");
        sw.WriteLine("<h2>" + thePerson.Age + "</h2>");
        sw.WriteLine("<body>");
        sw.WriteLine("<html>");

        sw.Close();        
                
        //List<Person> thePeople = new List<Person>();

        //StreamReader sr = new StreamReader("Person.txt");

        //while (!sr.EndOfStream)
        //{
        //    string temp = sr.ReadLine();

        //    string[] tempAr = temp.Split(' ');

        //    Person aPerson = new Person();

        //    aPerson.Firstname = tempAr[0];
        //    aPerson.Lastname = tempAr[1];

        //    thePeople.Add(aPerson);
        //}

        //sr.Close();

        //return thePeople;
        }
    }
}
