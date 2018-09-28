using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataService();

            var item = data.GetItems(1).FirstOrDefault();

            PrintData(item);

            var items = data.GetItems();

            foreach (var i in items)
            {
                PrintData(i);
            }

            var types = data.GetTypes();

            foreach (var t in types)
            {
                PrintData(t);
            }

            Console.ReadLine();
        }

        public static void PrintData(object obj)
        {
            var line = string.Empty;

            if (obj is Item)
            {
                var item = (Item)obj;
                line = string.Format("Item: {0}, Desc:{1}, Type:{2}, Status:{3}", item.ItemId, item.ItemDescription, item.TypeDescription, item.StatusDescription);
            }

            if (obj is App.Model.Type)
            {
                var type = (App.Model.Type)obj;
                line = string.Format("Type: {0}, Desc:{1} ", type.TypeId, type.TypeDescription);
            }

            Console.WriteLine(line);
        }
    }
}
