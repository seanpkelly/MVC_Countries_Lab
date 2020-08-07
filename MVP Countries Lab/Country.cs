using System;
using System.Collections.Generic;
using System.Text;

namespace MVP_Countries_Lab
{
    public class Country
    {
        public string Name { get; set; }
        public Continents Continent { get; set; }
        public List<string> Colors { get; set; }
        
        public Country (string Name, Continents Continent, List <string> Colors)
        {
            this.Name = Name;
            this.Continent = Continent;
            this.Colors = Colors;
        }

    }
    
}
