using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.DAL.Entities
{
    public class Topic
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountOfNotes{ get; set; }
        
        public int Userid { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Note> Notes { get; set; }


        
    }
}
