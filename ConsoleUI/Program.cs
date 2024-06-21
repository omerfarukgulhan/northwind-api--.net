using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            //ProductTestMemory();
        }

        private static void ProductTestMemory()
        {
            InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();

            foreach (var product in inMemoryProductDal.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var product in categoryManager.GetAll())
            {
                Console.WriteLine(product.CategoryName);
            }
        }
    }
}
