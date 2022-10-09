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
    public class TopicService : ITopicService
    {
        private IMapper mapperTopic;
        private IWorkUnit Database;

        public TopicService(IWorkUnit database)
        {
            Database = database;
            mapperTopic = new MapperConfiguration(cfg => cfg.CreateMap<Topic, TopicDTO>()
                .ReverseMap()).CreateMapper();
        }

        public IEnumerable<TopicDTO> GetAll() =>
            mapperTopic.Map<IEnumerable<Topic>, List<TopicDTO>>(Database.Topics.GetAll());

        public TopicDTO Get(int id) =>
            mapperTopic.Map<Topic, TopicDTO>(Database.Topics.Get(id));

        public IEnumerable<TopicDTO> GetAllByUser(int userid) =>
            mapperTopic.Map<IEnumerable<Topic>, List<TopicDTO>>(Database.Topics.GetAll()
                .Where(tp => tp.Userid == userid));
        
        public void Create(TopicDTO item)
        {
            Database.Topics.Create(mapperTopic.Map<TopicDTO, Topic>(item));
            Database.Save();
        }

        public void Delete(int id)
        {
            var data = Database.Topics.Get(id);

            if(data != null)
            {
                Database.Topics.Delete(id);
                Database.Save();
            }
        }
      
       
    }
}
