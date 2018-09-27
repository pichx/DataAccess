using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class Status
    {
        public int Id { get; set; }
        public string StatusDescription { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
