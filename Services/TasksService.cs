using Microsoft.AspNetCore.Mvc;
using Tasks.Models;
using Tasks.Repositiers;
using static System.Reflection.Metadata.BlobBuilder;

namespace Tasks.Services
{
    //public class TasksService : ITasksService
    //{
    //    private readonly ITasksRepository _TasksRepository;

    //    public TasksService(ITasksRepository TaskRepository)
    //    {
    //        _TasksRepository = TaskRepository;
    //    }
    //    public IEnumerable<TasksModel> GetAllTasks()
    //    {
    //        return _TasksRepository.GetAll();
    //    }
    //    private static List<TasksModel> tasks = new List<TasksModel>()
    //    {
    //        new TasksModel { id=328120985,TaskName="sleep",TaskNumber=1},
    //        new TasksModel {id=111111111,TaskName="delishes",TaskNumber=2},
    //    };

    //    [HttpPost]
    //    public void Add(TasksModel taskCreat)
    //    {
    //        _TasksRepository.Add(taskCreat);
    //    }
    //    [HttpPut]
    //    public void UpDateTask(TasksModel task2)
    //    {
    //        //TasksModel task1 = tasks.FirstOrDefault(x => x.id == task2.id);
    //        //if (task2 == null)
    //        //    return "NotFound";
    //        //task1.id = task2.id;
    //        //return "Ok";
    //      //  _TasksRepository.UpDateTask(task2);

    //    }
    //    [HttpDelete]
    //    public string DeleteTask(int id)
    //    {
    //        TasksModel task1 = tasks.FirstOrDefault(x => x.id == id);
    //        if (task1 == null)
    //            return "NotFound";
    //        tasks.Remove(task1);
    //        return "Delete";
    //    }
    //}

    public class TasksService : ITaskScervice
    {
        private readonly ITaskRepository _tasksRepository;

        public TasksService(ITaskRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;

        }

        public void CreateTask(TasksModel task)
        {
            _tasksRepository.CreateTask(task);
        }

        public void DeleteTask(TasksModel task)
        {
            _tasksRepository.DeleteTask(task);
        }

        public List<TasksModel> GetAllTasks(int Id)
        {
            return _tasksRepository.GetAllTasks(Id);
        }

        public List<TasksModel> GetAllTasksWithUser(int UserId)
        {
            return _tasksRepository.GetAllTasksWithUser(UserId);
        }

       

        public void UpdateTask(TasksModel task)
        {
            _tasksRepository.UpdateTask(task);
        }
        public List<TasksModel> GetAllTasksByUser(int userId)
        {
            return _tasksRepository.GetAllTasks(userId).Where(x => x.UserId == userId).ToList();
        }
        public List<TasksModel> GetAllTasksWithProject(int projectId)
        {
            return _tasksRepository.GetAllTasks(projectId).Where(x => x.ProjectId == projectId).ToList();
        }


    }
}

