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
    public class TopicRepository : ITopicRepository
    {
       
            private WebNoteContext db;

            public TopicRepository(WebNoteContext db)
            {
                this.db = db;
            }

            public IEnumerable<Topic> GetAll()
            {
                return db.Topics;
            }
            public Topic Get(int id)
            {
                return db.Topics.Find(id);
            }
            public void Create(Topic topic)
            {
                db.Topics.Add(topic);
            }
            public void Delete(int id)
            {
                Topic topic = db.Topics.Find(id);
                if (topic != null)
                    db.Topics.Remove(topic);

            }
            public void Update(Topic newTopic, int id)
            {
                Topic topic = db.Topics.Find(id);

                if (topic != null)
                {
                    db.Topics.Update(topic);
                }

            }

            public IEnumerable<Topic> GetTopicsByUser(int userid) =>
                db.Topics
                .AsQueryable()
                .Where(tp => tp.Userid == userid);
           
    }
}



