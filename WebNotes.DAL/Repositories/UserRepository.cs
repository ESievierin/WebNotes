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
    public class UserRepository : IUserRepository
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
         db.Entry(newUser).State = EntityState.Modified;
         db.Users.Update(newUser);
         
        }

        public User GetByLogin(string username) =>       
            db.Users
            .AsQueryable()
            .FirstOrDefault(us => us.UserName == username);
       
        public User GetByLoginAndPassword(string username, string password) =>
            db.Users
            .AsQueryable()
            .FirstOrDefault(us => us.UserName == username && us.Password == password);
      
    }
}
