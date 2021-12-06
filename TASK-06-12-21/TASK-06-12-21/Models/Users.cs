using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TASK_06_12_21.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string fullName { get; set; }

        public Roles role { get; set; }

        //Favorites should be unique, you cant fave one item twice. HashSet is useful here
        public HashSet<Favorites> favoriteItems { get; set; }
        public Baskets userBasket { get; set; }

    }
}
