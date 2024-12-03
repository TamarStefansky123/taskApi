using Tasks.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Tasks.Repositiers
{
    //    public interface ITasksRepository
    //    {
    //        public IEnumerable<TasksModel> GetAll();
    //        public void Add(TasksModel task);
    //     ///   public void UpDateTask(TasksModel task2);

    ///*        public void Save(TasksModel taskCreat);
    //        void Save();*/
    //    }
    public interface ITaskRepository
    {
        public List<TasksModel> GetAllTasks(int Id);

        // List<TasksWithUsers> GetAllTasksWithUsers();

        public void CreateTask(TasksModel task);

        public void UpdateTask(TasksModel task);

        public void DeleteTask(TasksModel task);
        public List<TasksModel> GetAllTasksWithUser(int UserId);
        public IEnumerable<TasksModel> GetAllTasksByUser();
        public List<TasksModel> GetAllTasksWithProject(int projectId);
    }
}
