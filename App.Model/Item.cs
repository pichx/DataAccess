using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemDescription { get; set; }
        public int TypeId { get; set; }
        public string TypeDescription { get; set; }
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
