using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.DAL.Entities
{
    public class Note
    {
        public int Id { get; set; }

        public int Topicid { get; set; }

        public string Name { get; set; }
        
        public string Text { get; set; }


        public virtual Topic Topic { get; set; }
        

        
        
    }
}
