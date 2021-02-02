using System;
using System.Collections.Generic;
using System.Text;

namespace aie_01_helloworld
{
    public class mainmenu
    {
        
        public static void program()
        {
            float prog;
            while (true)
            {
                Console.WriteLine("Choose Program!");
                Console.WriteLine("1 = Fortune Teller");
                Console.WriteLine("2 = Age Calculator");
                Console.WriteLine("3 = Circle Calculator");
                Console.WriteLine("4 = Temperature Converter");
                if (!float.TryParse(Console.ReadLine(), out prog))
                {
                    Console.WriteLine("Not a valid number.");
                    Console.WriteLine(prog);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
