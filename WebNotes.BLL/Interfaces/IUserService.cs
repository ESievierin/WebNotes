using System;
using WebNotes.BLL.DTO
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetAll();
        UserDTO Get(int id);

        void Registration(string login, string password);

        void Authorization(string login, string password);

        void Delete(int id);
    }
}
