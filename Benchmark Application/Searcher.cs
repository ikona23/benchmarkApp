using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benchmark_Application
{
    class Searcher
    {
        public List<Person> Contains(List<Person> theList, string searchList)
        {
            List<Person> returnList = new List<Person>();

            for (int l = 0; l < theList.Count; l++)
            {
                if(theList[l].ToString().ToLower().Contains(searchList))
                {
                    returnList.Add(theList[l]);
                }
            }

            return returnList;
        }


        public List<Person> EndsWith(List<Person> theList, string searchList)
        {
            List<Person> returnList = new List<Person>();

            foreach (Person p in theList)
            {
                if (p.ToString().ToLower().EndsWith(searchList))
                {
                    returnList.Add(p);
                }
            }

            return returnList;
        }


        public List<Person> StartsWith(List<Person> theList, string searchList)
        {
            List<Person> returnList = new List<Person>();

            for (int l = 0; l < theList.Count; l++)
            {
                if (theList[l].ToString().ToLower().Contains(searchList))
                {
                    returnList.Add(theList[l]);
                }
            }

            return returnList;
        }
    }
}
