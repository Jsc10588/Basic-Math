using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3D____Math_App
{
    class Exiting
    {
        public void Exit(string[] args)
        {
            string userSelction = "0";
            Console.WriteLine($"Are you sure you want to exit?");
            userSelction = Console.ReadLine();
            if (userSelction == "yes")
            {
                Console.WriteLine($"Thank you for stoping by");
                Console.ReadLine();
               
            }
        }
        
    }
}
