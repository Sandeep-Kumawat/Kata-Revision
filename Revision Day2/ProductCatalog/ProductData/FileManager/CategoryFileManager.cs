using ProductData.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProductData.FileManager
{
    public class CategoryFileManager
    {
        public static List<Category> ReadDataFromFile()
        {
            List<Category> CategoryList = new List<Category>();
            var fileName = @"C:\Users\s s infotech\Sandeep\Revision\Revision Day2\ProductCatalog\Product\bin\Debug\netcoreapp3.1\categoryData.csv";
            using FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var data = reader.ReadLine();
                    CategoryList.Add(ProcessCategory(data));

                }

            }
            return CategoryList;
        }
        public static Category ProcessCategory(string str)
        {
            var splitData = str.Split(',');
            Category category = new Category
            {
                Category_ID = int.Parse(splitData[0]),
                Category_Name = splitData[1],
                CategoryShortCode = splitData[2],
                CategoryDescription = splitData[3],

            };
            return category;
        }
        public static void AddCategoryInFile(string str)
        {
            var fileName = @"C:\Users\s s infotech\Sandeep\Revision\Revision Day2\ProductCatalog\Product\bin\Debug\netcoreapp3.1\categoryData.csv";
            using (FileStream fs = new FileStream(fileName, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write("\n" + str);
            }

        }
    }
}
