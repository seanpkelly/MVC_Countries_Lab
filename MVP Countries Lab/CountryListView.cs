using System;
using System.Collections.Generic;
using System.Text;

namespace MVP_Countries_Lab
{
    public class CountryListView
    {
        
        public List<Country> Countries {get; set;}

        public CountryListView() { this.Countries = Countries; }
        public CountryListView(List<Country> Countries) { this.Countries = Countries; }
            

        public void DisplayList(List<Country> Countries)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Country c = Countries[i];

                Console.WriteLine(i + " " + Countries[i].Name);
            }

        }

    }
}
