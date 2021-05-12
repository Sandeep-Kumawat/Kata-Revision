using ProductData.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProductData.FileManager
{
    public class ProductFileManager
    {
        public static List<Product> ReadDataFromFile()
        {
            List<Product> ProductList = new List<Product>();
            var fileName = @"C:\Users\s s infotech\Sandeep\Revision\Revision Day2\ProductCatalog\Product\bin\Debug\netcoreapp3.1\productData.csv";
            using FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var data = reader.ReadLine();
                    ProductList.Add(ProcessProduct(data));

                }

            }
            return ProductList;
        }
        public static Product ProcessProduct(string str)
        {
            var splitData = str.Split(',');
            Product product = new Product
            {
                Product_ID = int.Parse(splitData[0]),
                product_Name = splitData[1],
                Manufacturer = splitData[2],
                ProductShortCode = splitData[3],
                ProductCategory = splitData[4],
                ProductDescription = splitData[5],
                Selling_Price = int.Parse(splitData[6])
                
            };
            return product;
        }
        public static void AddProductInFile(string str)
        {
            var fileName = @"C:\Users\s s infotech\Sandeep\Revision\Revision Day2\ProductCatalog\Product\bin\Debug\netcoreapp3.1\productData.csv";
            using (FileStream fs = new FileStream(fileName, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write("\n"+str);
            }

        }
        public static void WriteAllDataIntoFile(List<string> list)
        {
            var fileName = @"C:\Users\s s infotech\Sandeep\Revision\Revision Day2\ProductCatalog\Product\bin\Debug\netcoreapp3.1\productData.csv";
            using (FileStream fs = new FileStream(fileName, FileMode.Truncate))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                list.ForEach(x => writer.WriteLine(x));
            }
        }
    }
}
