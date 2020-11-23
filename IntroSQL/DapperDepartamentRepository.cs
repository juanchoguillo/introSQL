using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace IntroSQL
{
    public class DapperDepartamentRepository : IDepartamentRepository 
    {

        private readonly IDbConnection _connection;
        
        public DapperDepartamentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void InsertDepartment(string newDepartment)
        {
            _connection.Execute("INSERT INTO departments(Name) VALUES(@departmentName);",
                new { departmentName = newDepartment });
        }

        public IEnumerable<Departaments> GetAllDepartaments()
        {
            return _connection.Query<Departaments>("SELECT * FROM departments;");
        }
        
    }
}
