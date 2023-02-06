using Microsoft.AspNetCore.Mvc;
using WebNotes.API.Models;
using WebNotes.BLL.DTO;
using WebNotes.BLL.Interfaces;
using WebNotes.BLL.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebNotes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteService noteService;

        public NoteController(INoteService noteservice) =>
            noteService = noteservice;



        [HttpGet("bytopicid/{id}")]
        public IEnumerable<NoteDTO> GetAllByTopic(int Id) =>
            noteService.GetAllByTopic(Id);



       
        [HttpGet("text/{id}")]
        public string GetText(int Id) =>
            noteService.GetNoteText(Id);

        [HttpGet("{id}")]
        public NoteDTO Get(int id) =>
          noteService.Get(id);


        [HttpPost("create")]
        public void Create([FromBody] NoteRequest request) =>
            noteService.Create(new NoteDTO(request.TopicId, request.Name, request.Text));
        
        
       
        [HttpDelete("{id}")]
        public void Delete(int id) =>
            noteService.Delete(id);

        [HttpPut("{id}")]

        public void Update(int id, [FromBody] NoteRequest request) =>
            noteService.Update(id, new NoteDTO(id,request.TopicId, request.Name, request.Text));
        
        
        
    }
}
