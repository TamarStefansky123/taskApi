using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tasks.Models;
using Tasks.Services;
using static System.Reflection.Metadata.BlobBuilder;

namespace Tasks.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class TasksController : ControllerBase
    //{
    //    private readonly ITasksService _TasksService;

    //    public TasksController(ITasksService tasksService)
    //    {
    //        _TasksService = tasksService;
    //    }


    //    [HttpGet]
    //    public IEnumerable<TasksModel> GetTasks()
    //    {
    //        return _TasksService.GetAllTasks();
    //    }

    //    [HttpPut("{id}")]
    //public IActionResult Updatetask(int id, TasksModel tasks)
    //{
    //    if (id != tasks.id)
    //    {
    //        return BadRequest();
    //    }

    //    _TasksService.UpDateTask(tasks);
    //    return NoContent();
    //}
    //public IActionResult Update(TasksModel task)
    //{
    //    _TasksService.Update(task);
    //    return Ok("success");
    //}

    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        int t = 0;
        private readonly ITaskScervice _tasksService;

        public TasksController(ITaskScervice tasksService)
        {
            _tasksService = tasksService;
        }
        [HttpGet("ProjectId/{id}")]
        public IActionResult GetAllTasksWithProject(int ProjectId)
        {
            var tasks = _tasksService.GetAllTasksWithProject(ProjectId);
            return Ok(tasks);
        }

        [HttpGet("{id}")]
         
        public List<TasksModel> GetAllTasks(int id)
        {
            return _tasksService.GetAllTasks(id);
        }

        [HttpGet("userId/{id}")]
        public IActionResult GetAllTasksByUser_1(int userId)
        {
            var tasks = _tasksService.GetAllTasksWithUser(userId);
            return Ok(tasks);
        }
       
        [HttpDelete]
        public IActionResult Delete(TasksModel task)
        {
            _tasksService.DeleteTask(task);
            return Ok("success");
        }
        
        [HttpPut]
        public IActionResult Update(TasksModel task)
        {
            _tasksService.UpdateTask(task);
            return Ok("success");
        }

        [HttpPost]
        public void Create(TasksModel task)
        {            
            _tasksService.CreateTask(task);
        }
    }
}


