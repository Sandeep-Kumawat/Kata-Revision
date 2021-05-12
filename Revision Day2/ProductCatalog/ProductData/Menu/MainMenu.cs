using System;
using System.Collections.Generic;
using System.Text;
namespace ProductData.Menu
{
    public class MainMenu
    {
        public static void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Hello, Please Select Option");
                Console.WriteLine("a. Category");
                Console.WriteLine("b. Product");
                Console.WriteLine("c. Exit App!");

                char ch = Convert.ToChar(Console.ReadLine());

                switch (ch)
                {
                    case 'a':
                        CategoryMenu.CategoryOperationMenu();
                        break;
                    case 'b':
                        ProductMenu.ProductOperationMenu();
                        
                        break;
                    case 'c':
                        Console.WriteLine("Exit");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                Console.Clear();
            }
        }
    }
}
    
