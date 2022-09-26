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
    public class UserRepository : IRepository<User>
    {
        private WebNoteContext db;

        public UserRepository(WebNoteContext db)
        {
            this.db = db;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }
        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }
        
        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);

        }
        public void Update(User newUser, int id)
        {
            User user = db.Users.Find(id);

            if (user != null)
            {
                db.Users.Update(newUser);
            }
        }
    }
}
