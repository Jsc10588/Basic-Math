using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3D____Math_App
{
    class Main_Menu
    {
        public void Menu(string[] args)

        {
            Console.Clear();
            Exiting Ex = new Exiting();
            Main_Menu mMenu = new Main_Menu();
            Addition add = new Addition();
            Subtraction sub = new Subtraction();
            Division div = new Division();
            Multiplication mult = new Multiplication();
            Console.WriteLine($"What would you like to do");
            Console.WriteLine($"Select (1) for addition");
            Console.WriteLine($"Select (2) for subtraction");
            Console.WriteLine($"Select (3) for division");
            Console.WriteLine($"Select (4) for multiplication");
            Console.WriteLine($"Or select (5) to exit the program");
            string userSwitch = "0";
            
                userSwitch = Console.ReadLine();
            switch (userSwitch)
            {
                case "1":
                    add.First(args);
                    break;
                case "2":
                    sub.Second(args);
                    break;
                case "3":
                    div.Third(args);
                    break;
                case "4":
                    mult.Fourth(args);
                    break;
                case "5":
                    Console.WriteLine($"Thank you for stopping by");
                    Console.ReadLine();
                    break; 
            }
        }
    }
}




