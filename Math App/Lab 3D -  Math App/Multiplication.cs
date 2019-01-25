using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3D____Math_App
{
    class Multiplication
    {
        public void Fourth(string[] args)

        {
            try


            {
                int A;
                int B;
                int C;
                Console.WriteLine($"Type the first number: ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Now type the second number: ");
                B = Convert.ToInt32(Console.ReadLine());
                C = (A * B);
                Console.WriteLine($"{A} * {B} equals {C}");
                Console.ReadLine();
                Main_Menu mMenu = new Main_Menu();
                mMenu.Menu(args);
            }
            catch (Exception Ex)
            {
                Console.WriteLine($"Please input a number");
                Console.ReadLine();
                Main_Menu mMenu = new Main_Menu();
                mMenu.Menu(args);



            }
        }
    }
}
