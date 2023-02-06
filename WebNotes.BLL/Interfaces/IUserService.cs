using System;
using WebNotes.BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.BLL.Interfaces
{
    public interface IUserService
    {
      
        UserDTO Get(int id);

        bool Registration(string login, string password);

        int Login(string login, string password);

        void Delete(int id);

        void Update(int id, UserDTO item);
    }
}
