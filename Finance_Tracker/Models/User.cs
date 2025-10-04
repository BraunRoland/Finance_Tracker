namespace Finance_Tracker.Models
{
    public class User
    {
        private int id;
        private string username;
        private string passwordHash;
        private string email;
        private DateTime createdAt;


        public User(int id, string username, string passwordHash, string email, DateTime createdAt)
        {
            this.id = id;
            this.username = username;
            this.passwordHash = passwordHash;
            this.email = email;
            this.createdAt = createdAt;
        }
        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string PasswordHash { get => passwordHash; set => passwordHash = value; }
        public string Email { get => email; set => email = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
    }
}
