using System;
using WebNotes.BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.BLL.Interfaces
{
    public interface INoteService
    {
        IEnumerable<NoteDTO> GetAll();
        IEnumerable<NoteDTO> GetAllByTopic(int topicid);
        NoteDTO Get(int id);
        string GetNoteText(int id);
        void Create(NoteDTO item);
        void Delete(int id);
        
    }
}
