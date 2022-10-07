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

        public int CountOfNotes { get; set; }

        public int Userid { get; set; }

        public TopicDTO(string name,int countOfNotes,int userid)
        {
            Name = name;
            CountOfNotes = countOfNotes;
            Userid = userid;
        }
    }
}
