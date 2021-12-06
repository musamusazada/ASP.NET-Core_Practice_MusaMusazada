using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TASK_06_12_21.Models
{
    public class Order
    {
        public int  Id { get; set; }
        public Users user { get; set; }
        public Baskets baskets { get; set; }
    }
}
