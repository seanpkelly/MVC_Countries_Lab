using System;
using System.Collections.Generic;
using System.Text;

namespace MVP_Countries_Lab
{
    public class CountryController
    {

            List<Country> CountryDb = new List<Country>
           {
            new Country("France", Continents.Europe, new List<string>(){"Red White & Blue" }),
            new Country("Brazil", Continents.SouthAmerica, new List<string>(){"Green & Yellow"}),
            new Country("Canada", Continents.NorthAmerica, new List<string>(){"Red & White" }),
            new Country("Thailand", Continents.Asia, new List<string>(){"Red White & Blue" }),
            new Country("China", Continents.Asia, new List<string>() { "Red & Yellow" }),
            new Country("Finland", Continents.Europe, new List<string>(){"Blue & White" }),
            new Country("Australia", Continents.Australia, new List<string>(){"Green & Yellow"}),
            new Country("Poland", Continents.Europe, new List<string>(){"Red & White" }),

           };
        
        public void CountryAction(Country c)
        {
            CountryView v = new CountryView(c);
            v.Display( c);
        }
        public void WelcomeAction()
        {
            bool programStart = true;
            while (programStart)
            {
                CountryListView cv = new CountryListView(CountryDb );
                Console.WriteLine("Hello please pick a country from the following list using the corresponding number: ");
                Console.WriteLine();
                cv.DisplayList(CountryDb);
                string input = Console.ReadLine();
                try
                {
                    int numInput;
                    int.TryParse(input, out numInput);
                    if (numInput >=0 && numInput < CountryDb.Count)
                    {
                        CountryView ccv = new CountryView(CountryDb[numInput]);
                        ccv.Display(CountryDb[numInput]);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry not a number");
                    programStart = true;
                }






            }
        }
    }
}
