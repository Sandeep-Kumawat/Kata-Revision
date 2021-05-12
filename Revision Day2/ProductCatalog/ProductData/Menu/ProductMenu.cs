using ProductData.Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Menu
{
    public class ProductMenu
    {
        public static void ProductOperationMenu()
        {
            Console.WriteLine("Please Select Product Operation");
            Console.WriteLine("a. Add a Product");
            Console.WriteLine("b. List all Products");
            Console.WriteLine("c. Delete a Product");
            Console.WriteLine("d. Search a Product");
            Console.WriteLine("e. Main Menu");
            char ch1 = Convert.ToChar(Console.ReadLine());

            switch (ch1)
            {
                case 'a':
                    Console.WriteLine("Enter Product Name");
                    var ProductName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(ProductName) || int.TryParse(ProductName, out _))
                    {
                        Console.WriteLine("Please Enter Only Char and It can not be Empty");
                        ProductName = Console.ReadLine();

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
                    Console.WriteLine("Enter Price");
                    int price = -1;
                    bool flag = Int32.TryParse(Console.ReadLine(), out price);
                    while (!flag || price <= 0)
                    {

                        Console.WriteLine("Please Enter Only Number and It can not be Empty/can not be negetive");
                        flag = Int32.TryParse(Console.ReadLine(), out price);

                    }
                    Console.WriteLine("Enter Manufacture Name");
                    var manufactureName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(manufactureName) || int.TryParse(manufactureName, out _))
                    {
                        Console.WriteLine("Please Enter Only Char and It can not be Empty");
                        manufactureName = Console.ReadLine();

                    }
                    Console.WriteLine("Enter Category Name");
                    var category = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(category) || int.TryParse(category, out _))
                    {
                        Console.WriteLine("Please Enter Only Char and It can not be Empty");
                        category = Console.ReadLine();

                    }
                    ProductOperation.AddProduct(ProductName, shortCode, desc, price, manufactureName, category);
                    break;
                case 'b':
                    ProductOperation.GetAllProduct();
                    break;
                case 'c':

                    break;
                case 'd':

                    break;
                case 'e':

                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    ProductOperationMenu();
                    break;
            }
        }
    }
}
