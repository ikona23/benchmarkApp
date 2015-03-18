using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Benchmark_Application
{
    public partial class Form1 : Form
    {
        List<Person> thePeople = new List<Person>();    
        List<Person> searchResult = new List<Person>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();

            thePeople = fm.LoadPeople();

            lbxPeople.Items.Clear();
            lbxPeople.Items.AddRange(thePeople.ToArray());
        }

        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            Sorter sorted = new Sorter(); //Makes the information in this method available to call

            List<Person> tempList = new List<Person>();

            tempList = sorted.SortAZ(thePeople); //loading the list thePople as tempList and sorting it

            thePeople = tempList;

            lbxSorted.Items.Clear();
            lbxSorted.Items.AddRange(thePeople.ToArray());
        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            Sorter sorted = new Sorter(); //Makes the information in this method available to call

            List<Person> tempList = new List<Person>();

            tempList = sorted.SortZA(thePeople); //loading the list thePeople as tempList and sorting it

            thePeople = tempList;

            lbxSorted.Items.Clear();
            lbxSorted.Items.AddRange(thePeople.ToArray());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Searcher searchList = new Searcher();

            List<Person> tempSearch = new List<Person>();

            if(rdoStartsWith.Checked)
            {

            }

            else if(rdoEndsWith.Checked)
            {
                searchResult = searchList.StartsWith(thePeople, tbxSearch.Text);

                lbxSearch.Items.Clear();
                lbxSearch.Items.AddRange(searchResult.ToArray());
            }

            else if(rdoContains.Checked)
            {
                searchResult = searchList.Contains(thePeople, tbxSearch.Text);

                lbxSearch.Items.Clear();
                lbxSearch.Items.AddRange(searchResult.ToArray());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager();

            Person selPerson = (Person)lbxSearch.SelectedItem;

            fm.SavePerson(selPerson);
        }

        
    }
}
