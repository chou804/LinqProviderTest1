﻿using LinqToProvider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace LinqProviderTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=Northwind.db3;Version=3;";
            using (var con = new SQLiteConnection(constr))
            {
                con.Open();
                Northwind db = new Northwind(con);

                string city = "London";

                var query = db.Customers.Where(c => c.City == city)
                                        .Select(c => new { Name = c.ContactName, Phone = c.Phone });

                Console.WriteLine("Query:\n{0}\n", query);

                var list = query.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine("{0}", item);
                }

                Console.ReadLine();
            }

        }
    }
}
