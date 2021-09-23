using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] fruits = {
                "Apple",
                "Watermelon",
                "Orange",
                "Pear",
                "Strawberry",
                "Grape",
                "Plum",
                "Mango",
                "Blueberry",
                "Papaya",
                "Apricot",
                "Mandarin",
                "Banana",
                "Grapefruit"};
            // Method Syntax

            var fruitTest = fruits.Where(fruit => fruit.Contains('a'));
            Console.Write("fruits with a are : ");
            foreach (string fruit in fruitTest)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine("\n"+"it is very easy with Linq MAth Operators as you see " + new int[] { 0, 1, 2, 3, 4 }.Sum());

            var evennumbers = new int[] { 2, 4, 6, 8, 10,12,14 };
            var filtedevennumbers = from numbers in evennumbers
                                    where numbers % 3 == 0
                                    select numbers;
            Console.Write("\n"+"even numbers,can be divided with 3 are ");
            foreach (var no in filtedevennumbers)
            {
                Console.Write(no + " ");
            }
            int sumFilteredevennumbers = filtedevennumbers.Sum();
            Console.WriteLine("\n"+"Sum of the filteredevennumbers,without Array,with LINQ " + sumFilteredevennumbers);

            string[] names = { "Marco", "Linus", "Tob", "Marie", "Gerlinde", "Johannes" };
            var linqTest = from name in names
                           where name.Contains('i')
                           select name;
            Console.WriteLine("Names with i are ");
            foreach (string name in linqTest)
            {
                Console.WriteLine(name);
            }

            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName= "Computer"},
                new Category{CategoryId=2, CategoryName= "Handy"},

            };

            List<Product> products = new List<Product>
            {
                new Product {ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram", UnitPrice=10000,UnitsInStock=5 },
                new Product {ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram", UnitPrice=8000,UnitsInStock=3 },
                new Product {ProductId=3,CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="8 GB Ram", UnitPrice=6000,UnitsInStock=2 },
                new Product {ProductId=4,CategoryId=2,ProductName="Samsung Handy",QuantityPerUnit="4 GB Ram", UnitPrice=4000,UnitsInStock=15 },
                new Product {ProductId=5,CategoryId=2,ProductName="Apple Handy",QuantityPerUnit="4 GB Ram", UnitPrice=12000,UnitsInStock=0 },
            };

            Console.WriteLine("-------Algoritmic");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && (product.ProductName).Contains("Handy"))
                {
                    Console.WriteLine(product.ProductName + "with algoritmic");
                }

            }
            Console.WriteLine("--------LINQ--------");
            var result = products.Where(p => p.UnitPrice > 5000 && p.ProductName.Contains("Handy"));
            foreach (var rsl in result)
            {
                Console.WriteLine(rsl.ProductName + " with LINQ");
            }
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {

            return products.Where(product => product.UnitPrice > 5000 && product.ProductName.Contains("Handy")).ToList();
        }



        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public int UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
        }
        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }

        }
    }
}
