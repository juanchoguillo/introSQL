using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;


namespace IntroSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperDepartamentRepository(conn);

            var departaments = repo.GetAllDepartaments();

            Console.WriteLine("DepartamentID, Name");

            foreach (var item in departaments)
            {
                Console.WriteLine($"{ item.DepartmentID} { item.Name}");
            }

            //Console.WriteLine("Type the new Department");

            //string userInput = Console.ReadLine();

            //repo.InsertDepartment(userInput);


          



            var repoProducts = new DapperProductRepository(conn);

            repoProducts.CreateProduct();

            var products = repoProducts.GetAllProducts();

            Console.WriteLine("_______________________________");

            Console.WriteLine("CategoryId, Name, OnSale, Price, ProductID, StockLevel");

            foreach(var product in products)
            {
                Console.WriteLine($"{product.CategoryId} , {product.Name}, {product.OnSale}, {product.Price}, {product.ProductID}, {product.StockLevel}");
            }

            
        }
    }
}
