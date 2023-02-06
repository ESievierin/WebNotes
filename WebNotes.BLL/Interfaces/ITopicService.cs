using System;
using WebNotes.BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNotes.BLL.Interfaces
{
    public interface ITopicService
    {
      
        IEnumerable<TopicDTO> GetAllByUser(int userid);
        TopicDTO Get(int id);


        void Create(TopicDTO item);
        void Delete(int id);
        void Update(int id, TopicDTO item);
    }
}
