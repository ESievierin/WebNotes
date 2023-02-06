using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNotes.DAL.Entities;

namespace WebNotes.DAL.Interfaces
{
    public interface ITopicRepository
    {
        Topic Get(int id);

        IEnumerable<Topic> GetTopicsByUser(int userid);
        void Create(Topic item);
        void Delete(int id);
        void Update(Topic newitem, int id);
    }

}

