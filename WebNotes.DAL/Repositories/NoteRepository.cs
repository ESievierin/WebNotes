using WebNotes.DAL.EF;
using WebNotes.DAL.Entities;
using WebNotes.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.DAL.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private WebNoteContext db;

        public NoteRepository(WebNoteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Note> GetAll()
        {
            return db.Notes;
        }
        public Note Get(int id)
        {
            return db.Notes.Find(id);
        }

        public void Create(Note note)
        {
            db.Notes.Add(note);
        }
        public void Delete(int id)
        {
            Note note = db.Notes.Find(id);
            if(note != null)
                db.Notes.Remove(note);
         
        }
        public void Update(Note newNote,int id)
        {
            Note note = db.Notes.Find(id);

            if (note != null)
            {
                db.Notes.Update(newNote);
            }

        }

        public IEnumerable<Note> GetNotesByTopic(int topicid) =>
            db.Notes
            .AsQueryable()
            .Where(nt => nt.Topicid == topicid);
    }
}
