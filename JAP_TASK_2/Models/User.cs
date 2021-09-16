using System.Collections.Generic;

namespace JAP_TASK_2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Rating> MyRatings { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}