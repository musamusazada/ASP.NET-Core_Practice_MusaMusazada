using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TASK_06_12_21.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public float price { get; set; }

        public Category categoryName { get; set; }
    }
}
