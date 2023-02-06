using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.BLL.DTO
{
    public class TopicDTO
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public int Userid { get; set; }

        public TopicDTO(string name,int userid)
        {
            Name = name;
            
            Userid = userid;
        }
        public TopicDTO(int id,string name, int userid)
        {
            Id = id;
            Name = name;

            Userid = userid;
        }
    }
}
