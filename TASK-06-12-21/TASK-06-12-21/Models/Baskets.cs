using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TASK_06_12_21.Models
{
    public class Baskets
    {
        public int Id { get; set; }
        public ICollection<Product> productsInBasket { get; set; }
    }
}
