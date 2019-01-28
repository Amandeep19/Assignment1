using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Amandeep
{
    public class Program
    {
        Rectangle rectangle = new Rectangle();
        int len, wid;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.RecSelection();
            p.Menu();
            Console.ReadKey();
        }
        public void Menu()
        {
            int option;
            do
            {

                Console.WriteLine("\n1) Get Rectangle Length");
                Console.WriteLine("2) Change Rectangle Length");
                Console.WriteLine("3) Get Rectangle Width");
                Console.WriteLine("4) Change Rectangle Width");
                Console.WriteLine("5) Get Rectangle Perimeter");
                Console.WriteLine("6) Get Rectangle Area");
                Console.WriteLine("7) Exit");
                do
                {
                    Console.Write("\n select any of the above options: ");
                }
                while ((!int.TryParse(Console.ReadLine(), out option)) ||
                ((option != 1) &&
                 (option != 2) &&
                 (option != 3) &&
                 (option != 4) &&
                 (option != 5) &&
                 (option != 6) &&
                 (option != 7)
                 ));
                if (option == 1)
                {
                    len = rectangle.GetLength();
                    Console.WriteLine("\n length of the rectangle is : {0}", len);
                }
                else if (option == 2)
                {
                    do
                    {
                        Console.Write("\n enter the length in integer: ");
                    } while (!int.TryParse(Console.ReadLine(), out len));
                    rectangle.SetLength(len); 
                    int l = rectangle.GetLength();
                    Console.WriteLine("\n Length is set to : {0}", l);
                }
                else if (option == 3)
                {
                    wid = rectangle.GetWidth(); 
                    Console.WriteLine("\n width of the rectangle is {0}", wid);
                }
                else if (option == 4)
                {
                    do
                    {
                        Console.Write("\n enter the width in integer: ");
                    } while (!int.TryParse(Console.ReadLine(), out wid));
                    rectangle.SetWidth(wid); 
                    int l = rectangle.GetWidth();
                    Console.WriteLine("\n Width is set to {0}", l);
                }
                else if (option == 5)
                {
                    int perimeter = rectangle.GetPerimeter();
                    Console.WriteLine("\n perimeter of rectangle is {0}", perimeter);
                }
                else if (option == 6)
                {
                    int area = rectangle.GetArea(); 
                    Console.WriteLine("\n area of rectangle is {0}", area);
                }
                else if (option == 7)
                {
                    Environment.Exit(0); 
                }
            } while (option != 7);
        }
        public void RecSelection()
        {
            int ans;
            Console.WriteLine("1) Default rectangle");
            Console.WriteLine("2) Custom rectangle");
            do
            {
                Console.Write("\n select from the above option: ");
            } while ((!int.TryParse(Console.ReadLine(), out ans)) || ((ans != 1) && (ans != 2)));
            if (ans == 1)
            {
                len = rectangle.GetLength();
                wid = rectangle.GetWidth();
                Console.WriteLine("\nCustom rectangle is of {0} x {1}", len, wid); 
            }
            else if (ans == 2)
            {
                do
                {
                    Console.Write("\n enter the length in integer: ");
                } while (!int.TryParse(Console.ReadLine(), out len));
                rectangle.SetLength(len);
                do
                {
                    Console.Write("\n enter the width in integer: ");
                } while (!int.TryParse(Console.ReadLine(), out wid));
                rectangle.SetWidth(wid);
                Console.WriteLine("\nCustom rectangle is of {0} x {1}", len, wid);
            }
        }
    }
}
