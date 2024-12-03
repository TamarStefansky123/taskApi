namespace Tasks.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<TasksModel> Tasks { get; set; } = new List<TasksModel>();
    }
}
