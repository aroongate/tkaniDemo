using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOOtkaniDemo.database
{
    internal class OrderItem
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string description { get; set; }
        public string expr1 { get; set; }
        public double price { get; set; }
        public int? discount { get; set; }
        public byte[] image { get; set; }
        public int count { get; set; }
    }
}
