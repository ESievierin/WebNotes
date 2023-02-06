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
    public class EFWorkUnit : IWorkUnit
    {
        private WebNoteContext  db;
        private NoteRepository  noteRepository;
        private TopicRepository topicRepository;
        private UserRepository userRepository;

        public EFWorkUnit()
        {
            db = new WebNoteContext();
        }
        public INoteRepository Notes
        {
            get
            {
                if (noteRepository == null)
                {
                    noteRepository = new NoteRepository(db);
                }
                return noteRepository;
            }
        }
        public ITopicRepository Topics
        {
            get
            {
                if (topicRepository == null)
                {
                    topicRepository = new TopicRepository(db);
                }
                return topicRepository;
            }
        }
        public IUserRepository Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}
