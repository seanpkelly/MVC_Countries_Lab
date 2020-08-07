using System;
using System.Collections.Generic;
using System.Text;

namespace MVP_Countries_Lab
{
   public class WelcomeView
    {
            public void Display()
            {
            //This is all for displaying things, no functionality should in your view 
            //Save for getting user input that gets passed up to the controller
            
           
                Console.WriteLine("Welcome to the MVC Countries app!");
                Console.WriteLine("Press any key to continue.");

                Console.ReadKey();
               
            }

    }
}
