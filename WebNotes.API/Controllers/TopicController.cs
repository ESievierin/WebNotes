using Microsoft.AspNetCore.Mvc;
using WebNotes.API.Models;
using WebNotes.BLL.DTO;
using WebNotes.BLL.Interfaces;

namespace WebNotes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicService topicService;       
        
        public TopicController(ITopicService topicservice) =>
            topicService = topicservice;
        [HttpGet("byuser/{id}")]
        public IEnumerable<TopicDTO> GetAllByUser(int id) =>
            topicService.GetAllByUser(id);



        [HttpGet("{id}")]
        public TopicDTO Get(int id) =>
            topicService.Get(id);
        
           

        
        [HttpPost("create")]
        public void Create([FromBody] TopicRequest request)
        {
            topicService.Create(new TopicDTO(request.Name, request.UserId));
        }




        [HttpPost("update")]
        public void Update(int id, [FromBody] TopicRequest request) =>
            topicService.Update(id, new TopicDTO(id,request.Name, request.UserId));
       
        


        [HttpDelete]
        public void Delete(int id) =>
            topicService.Delete(id);
        
    }
}
