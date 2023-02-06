using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.BLL.DTO
{
    public class UserDTO
    {
        public int Id { get; private set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime CreationTime { get; set; }

        public UserDTO(string userName,string password)
        {
            UserName = userName;
            Password = password;
        }
        public UserDTO(int id ,string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
        }
    }

}
