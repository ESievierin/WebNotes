using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.BLL.DTO
{
    public class NoteDTO
    {
        public int Id { get; private set; }

        public int Topicid { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public NoteDTO(int topicid,string name,string text)
        {
            Topicid = topicid;
            Name = name;
            Text = text;
        }
        public NoteDTO(int id,int topicid, string name, string text)
        {
            Id = id;
            Topicid = topicid;
            Name = name;
            Text = text;
        }
    }
}
