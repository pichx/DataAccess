using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using App.Model;

namespace DataAccess
{
    public class DataService
    {
        public string ConnectionString { get; set; }

        public Item GetItem(int id)
        {
            Item item = null;
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString;// "Server=locahost;Database=Products;Trusted_Connection=true";
                conn.Open();
                var command = "select * from Item where ItemId = @Id;";
                item = conn.Query<Item>(command, new { id }).FirstOrDefault();
                conn.Close();
            }

            return item;
        }

        public List<App.Model.Type> GetTypes()
        {
            List<App.Model.Type> types = null;
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString;// "Server=locahost;Database=Products;Trusted_Connection=true";
                conn.Open();
                var command = "select * from type;";
                types = conn.Query<App.Model.Type>(command).ToList();
                conn.Close();
            }

            return types;
        }
    }
}
