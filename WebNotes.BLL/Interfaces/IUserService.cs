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

        bool Registration(string username, string password);

        int Login(string username, string password);

        void Delete(int id);
    }
}
