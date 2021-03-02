using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();

        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            Console.WriteLine("....RESULT YAPISI BAŞLANGIÇ....");

            var result = productManager.GetProductDetails();

            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            Console.WriteLine("......RESULT YAPISI SON....");

            //foreach (var product in productManager.GetAll().Data)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //Console.WriteLine("...................");

            //foreach (var product in productManager.GetAllByCategory(2).Data)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //Console.WriteLine("...................");

            //foreach (var product in productManager.GetByUnitPrice(50, 200).Data)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //Console.WriteLine("...................");

            //foreach (var product in productManager.GetProductDetails().Data)
            //{
            //    Console.WriteLine(product.ProductName+ " / "+ product.CategoryName);
            //}
        }
    }
}
