namespace Domain
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Description { get; set; } 
        public string Status { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}