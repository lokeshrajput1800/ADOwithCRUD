using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data;
using System.Data.Common;


namespace ADOwithCRUD.Models
{
    public class EmployeesDataAccess
    {
        dbConnection DbConnection;

        public EmployeesDataAccess()
        {
            DbConnection = new dbConnection();

        }
        public List<Employees>GetEmployees()
        {
            string sp = "sp_Employee";
            SqlCommand sql = new SqlCommand(sp, DbConnection.Connection);
            sql.CommandType = System.Data.CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@action", "SELECT_JOIN");
            if (DbConnection.Connection.State == System.Data.ConnectionState.Closed)
            {
                sql.Connection.Open();
            }
            SqlDataReader reader = sql.ExecuteReader();
            List<Employees> employees = new List<Employees>();
            while(reader.Read())
            {
                Employees emp = new Employees();
                 emp.id = (int)reader["id"];
                emp.Ename = reader["Ename"].ToString();
                emp.Email = reader["email"].ToString();
                emp.Mobile = reader["mobile"].ToString();
                emp.address= reader["address"].ToString();
                employees.Add(emp);
              
            }
            DbConnection.Connection.Close();
            return employees;






        }
    }
}
