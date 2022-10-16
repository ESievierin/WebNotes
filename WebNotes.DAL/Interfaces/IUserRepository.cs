using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNotes.DAL.Entities;

namespace WebNotes.DAL.Interfaces
{
    public interface IUserRepository
    {
        
        User Get(int id);

        int GetUserByUserNameAndPassword(string username, string password);
        void Create(User item);
        void Delete(int id);
        void Update(User newitem,int id);

        

    }
}
