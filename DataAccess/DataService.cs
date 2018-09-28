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
        public string ConnectionString = "Server=localhost;Database=Products;Trusted_Connection=true";

        private string qryFullItem = @"select a.ItemId, a.ItemDescription, a.TypeId, b.TypeDescription, a.StatusId, c.StatusDescription, a.ChangeDate
                                        from dbo.Item a 
                                        inner join dbo.[Type] b on a.TypeId = b.TypeId
                                        inner join dbo.[Status] c on a.StatusId = c.StatusId ";
        public List<Item> GetItems(int? id = null)
        {
            List<Item> item = null;
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString;// "Server=locahost;Database=Products;Trusted_Connection=true";
                conn.Open();
                var where = id != null ? " where ItemId = @id" : string.Empty ;
                var command = qryFullItem + where;
                item = conn.Query<Item>(command, new { id }).ToList();
                conn.Close();
            }

            return item;
        }

        public List<App.Model.Type> GetTypes()
        {
            List<App.Model.Type> types = null;
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();
                var command = "select * from dbo.[Type];";
                types = conn.Query<App.Model.Type>(command).ToList();
                conn.Close();
            }

            return types;
        }
    }
}
