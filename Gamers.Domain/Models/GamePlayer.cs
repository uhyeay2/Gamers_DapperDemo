namespace Gamers.Domain.Models
{
    public class GamePlayer
    {
        public GamePlayer(int id, string firstName, string lastName, string email, string gender, string ipAddress)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            IpAddress = ipAddress;
        }

        public GamePlayer()
        {
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
    }
}
