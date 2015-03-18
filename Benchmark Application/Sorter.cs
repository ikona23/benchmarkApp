using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benchmark_Application
{
    public class Sorter
    {
        public List<Person> SortAZ(List<Person> theList)
        {
            for(int i = 0; i < theList.Count; i++)
            {
                for (int j = 0; j < theList.Count - 1; j++)
                {
                    if (theList[j].ToString().CompareTo(theList[j + 1].ToString()) > 0)
                    {
                        Person temp = theList[j];
                        theList[j] = theList[j + 1];
                        theList[j + 1] = temp;
                    }
                }
            }
            return theList;
        }

        public List<Person> SortZA(List<Person> theList)
        {
            for (int i = 0; i < theList.Count; i++)
            {
                for (int j = 0; j < theList.Count - 1; j++)
                {
                    if (theList[j].ToString().CompareTo(theList[j + 1].ToString()) < 0)
                    {
                        Person temp = theList[j];
                        theList[j] = theList[j + 1];
                        theList[j + 1] = temp;
                    }
                }
            }
            return theList;

            //TO DO write Sort ZA algorithm
            //throw new System.NotImplementedException();
        }
    }
}
