﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
          
        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime CreationTime { get; set; }

        public virtual ICollection<Topic> Topics { get; set;}
    }
}
