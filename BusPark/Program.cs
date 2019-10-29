
using Dapper;
using DbUp;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace BusPark
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=A-305-06;Database=BookStore;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            Console.WriteLine("1- Без механика");
            Console.WriteLine("2- В ремонте");
            int t = Convert.ToInt32(Console.ReadLine());
          //  if (t == 1){}
            var upgrader =
            DeployChanges.To
                .SqlDatabase(CONNECTION_STRING)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .LogToConsole()
                .Build();

            upgrader.PerformUpgrade();

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                //connection.Insert(book);
                //connection.Execute("Insert into Books values (@Id, @Name, @Price);", book);
            }
        }
    }
}