using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNotes.BLL.DTO;
using WebNotes.BLL.Interfaces;
using WebNotes.DAL.Entities;
using WebNotes.DAL.Interfaces;
using AutoMapper;

namespace WebNotes.BLL.Service
{
    public class UserService : IUserService
    {
        private IWorkUnit Database;
        private IMapper mapperUser;

        public UserService(IWorkUnit database)
        {
            Database = database;
            mapperUser = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()
                .ReverseMap()).CreateMapper();
        }



        public UserDTO Get(int id) =>
            mapperUser.Map<User, UserDTO>(Database.Users.Get(id));
        
        public void Create(UserDTO item)
        {
            item.CreationTime = DateTime.Now;
            Database.Users.Create(mapperUser.Map<UserDTO, User>(item));
            Database.Save();
        }

        public void Delete(int id)
        {
            var data = Database.Users.Get(id);
            if (data != null)
            {
                Database.Users.Delete(id);
                Database.Save();
            }
        }

        public bool Registration(string username,string password)
        {
            UserDTO newUser = new UserDTO(username, password);

            if(Database.Users.GetByLoginAndPassword(username,password) == null)
            {
                Create(newUser);
                return true;
            }
            return false;
        }

        public int Login(string username, string password) =>
            Database.Users.GetByLoginAndPassword(username, password).id;
        
       
    }
}
