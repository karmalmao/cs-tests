using System;
using System.Collections.Generic;
using System.Text;

namespace aie_01_helloworld
{
    public class fortuneteller

    {

        string geoloc;
        float childnum = 0;
        string partname;
        string jobtitle;

        public void ft() {
            
            
            
            
            
            
            string output = string.Format("You will be an {0} in {1}, and married to {2} with {3} kids",
               jobtitle, geoloc, partname, childnum);
            Console.WriteLine(output);
            Console.WriteLine("Would you like to go to main menu? ");
            Console.WriteLine("1 = Yes");
            Console.WriteLine("2 = No");

          

        }

}
    }

