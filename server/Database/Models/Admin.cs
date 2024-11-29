namespace server.Database.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string AdminName { get; set; }
        public string AdminEmail { get; set; }
        public string Password { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
    }
}
