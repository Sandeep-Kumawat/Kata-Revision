using ProductData.Entities;
using ProductData.FileManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Operation
{
    public class CategoryOperation
    {

        static List<Category> data = CategoryFileManager.ReadDataFromFile();
        static int lastId = data[data.Count - 1].Category_ID;
        public static void GetAllCategory()
        {

            data.ForEach((i) =>
            {
                Console.WriteLine($"{i.Category_ID}, {i.Category_Name}, {i.CategoryShortCode}," +
                    $" {i.CategoryDescription}");
            });
            Console.ReadKey();

        }
        public static void AddCategory(string categoryName, string shortCode, string desc)
        {

            var addCategoryData = $"{++lastId},{categoryName},{shortCode},{desc}";
            CategoryFileManager.AddCategoryInFile(addCategoryData);
            data = CategoryFileManager.ReadDataFromFile();
            Console.ReadKey();

        }
        public static void SearchCategory(string name)
        {
            var searchData = data.Find((i) => i.Category_Name == name);
            Console.WriteLine($"{searchData.Category_ID}, {searchData.Category_Name}, {searchData.CategoryShortCode}," +
                   $" {searchData.CategoryDescription}");
            Console.ReadKey();
        }
        public static void DeleteCategory(string name)
        {
            var searchData = data.Find((i) => i.Category_Name == name);
            data.Remove(searchData);
            List<string> list = new List<string>();
            data.ForEach(x => list.Add($"{x.Category_ID},{x.Category_Name},{x.CategoryShortCode},{x.CategoryDescription}"));
            ProductFileManager.WriteAllDataIntoFile(list);

        }
    }
}

