using Microsoft.AspNetCore.Mvc;
using Tasks.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Tasks.Services
{
    //public interface ITasksService
    //{
    //    public IEnumerable<TasksModel> GetAllTasks();
    //    public void Add(TasksModel taskCreat);
    //   public void UpDateTask(TasksModel task2);
    //   // void Updatetask(TasksModel tasks);
    //}
    public interface ITaskScervice
    {
        public List<TasksModel> GetAllTasksByUser(int userId);
        public List<TasksModel> GetAllTasksWithUser(int UserId);
        public List<TasksModel> GetAllTasksWithProject(int projectId);
        public List<TasksModel> GetAllTasks(int Id);

        public void CreateTask(TasksModel task);

        public void UpdateTask(TasksModel task);

        public void DeleteTask(TasksModel task);
    }
}