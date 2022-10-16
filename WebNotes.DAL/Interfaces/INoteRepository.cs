using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNotes.DAL.Entities;

namespace WebNotes.DAL.Interfaces
{
    public interface INoteRepository
    {
        Note Get(int id);

        IEnumerable<Note> GetNotesByTopic(int topicid);
        void Create(Note item);
        void Delete(int id);
        void Update(Note newitem, int id);
    }
}
