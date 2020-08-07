using System;
using System.Collections.Generic;
using System.Text;

namespace MVP_Countries_Lab
{
    public class CountryView
    {
        
        public Country DisplayCountry{ get; set; }
        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }
        
       
        public void Display(Country c)
        {
            
            Console.WriteLine("Here's your country: ");
            Console.WriteLine($"You chose: {c.Name}");
            Console.WriteLine($"It's on the continent: {c.Continent}");
            for (int i = 0; i < c.Colors.Count; i++)
            {
                Console.WriteLine($"Their national colors are: {c.Colors[i]} ");
            }
            
            Console.WriteLine("Press any key to return to the list view.");
            Console.ReadKey();
        }

    }
}
