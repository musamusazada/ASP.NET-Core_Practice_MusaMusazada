﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TASK_06_12_21.Models
{
    public class Roles
    {
        public int Id { get; set; }
        public string roleName { get; set; }

        public ICollection<Users> userList{ get; set; }
    }
}
