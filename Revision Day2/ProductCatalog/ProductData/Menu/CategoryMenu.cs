using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Menu
{
    public class CategoryMenu
    {
        public static void CategoryOperationMenu()
        {
            Console.WriteLine("Please Select Category Operation");
            Console.WriteLine("a. Enter a Category");
            Console.WriteLine("b. List all Categories");
            Console.WriteLine("c. Delete a Category");
            Console.WriteLine("d. Search a Category");
            Console.WriteLine("e. Main Menu");
            char ch1 = Convert.ToChar(Console.ReadLine());

            switch (ch1)
            {
                case 'a':
                    Console.WriteLine("Enter Category Name");
                    var categoryName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(categoryName) || int.TryParse(categoryName, out _))
                    {
                        Console.WriteLine("Please Enter Only Char and It can not be Empty");
                        categoryName = Console.ReadLine();
                        //break;
                    }
                    Console.WriteLine("Enter Short Code");
                    var shortCode = Console.ReadLine();

                    Console.WriteLine("Enter Description");
                    var desc = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(desc) || int.TryParse(desc, out _))
                    {
                        Console.WriteLine("Please Enter Only Char and It can not be Empty");
                        desc = Console.ReadLine();
                    }
                    
                    break;
                case 'b':
                    
                    Console.ReadKey();
                    break;
                case 'c':
                    
                    break;
                case 'd':
                  
                    break;
                case 'e':

                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    CategoryOperationMenu();
                    break;

            }
        }
    }
}
