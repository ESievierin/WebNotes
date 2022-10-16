using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNotes.BLL.DTO;
using WebNotes.BLL.Interfaces;
using WebNotes.DAL.Entities;
using WebNotes.DAL.Interfaces;

using AutoMapper;

namespace WebNotes.BLL.Service
{
    public class NoteService : INoteService
    {
        private IMapper mapperNote;
        private IWorkUnit Database;
        public NoteService(IWorkUnit database)
        {
            Database = database;
            mapperNote = new MapperConfiguration(cfg => cfg.CreateMap<Note,NoteDTO>().ReverseMap()).CreateMapper();
        }
     
        public NoteDTO Get(int id) =>
             mapperNote.Map<Note, NoteDTO>(Database.Notes.Get(id));
        
        public IEnumerable<NoteDTO> GetAllByTopic(int topicid) =>
            mapperNote.Map<IEnumerable<Note>, IEnumerable<NoteDTO>>(Database.Notes.GetNotesByTopic(topicid));
        public string GetNoteText(int id) =>
            Database.Notes.Get(id).Text;
        public void Create(NoteDTO item)
        {
            Database.Notes.Create(mapperNote.Map<NoteDTO, Note>(item));
            Database.Save();
        }
        public void Delete(int id)
        {
            var data = Database.Notes.Get(id);
            if (data != null)
            {
                Database.Notes.Delete(id);
                Database.Save();
            }
        }
       
            
        
            
    }
}
