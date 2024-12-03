namespace Tasks.Models
{
    public class TasksModel
    {
        public int id { get; set; }
        public string TaskName { get; set; }
        public int TaskNumber { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
    }
}
