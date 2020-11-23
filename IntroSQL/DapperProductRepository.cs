using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace IntroSQL
{
    public class DapperProductRepository
    {

        private readonly IDbConnection _connection;


        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable <Products> GetAllProducts()
        {
            return _connection.Query<Products>("SELECT * FROM products;");
        }

       


        public void  CreateProduct()
        {
            _connection.Execute("INSERT INTO products(Name, Price, CategoryID, Onsale, StockLevel) VALUES ('Daniel Figueroa', 15, 10, 0, 20 );");
        }
    }
}

//INSERT INTO table_name(column1, column2, column3, ...)
//VALUES(value1, value2, value3, ...);