using ProductApplication.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductApplication.Models
{
    public class Database
    {
        public Products Products { get; set; }
        SqlConnection conn;
        public Database()
        {
            string connString = @"Server=DESKTOP-8E7Q8IH\SQLEXPRESS; Database=AP.net; Integrated Security=true";
            conn = new SqlConnection(connString);
            Products = new Products(conn);
        }
    }
}