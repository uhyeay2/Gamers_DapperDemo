using Gamers.DataAccess.Abstraction;

namespace Gamers.DataAccess.DataRequests.GamePlayers
{
    public class InsertGamePlayer : IDataRequest
    {
        public InsertGamePlayer()
        {
            
        }

        public InsertGamePlayer(string firstName, string lastName, string email, string gender, string ipAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            IpAddress = ipAddress;
        }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;

        public object GetParameters() => new { FirstName, LastName, Email, Gender, IpAddress };

        public string GetSql() =>
        @"
            INSERT INTO GamePlayers ( FirstName, LastName, Email, Gender, IpAddress )
                             VALUES ( @FirstName, @LastName, @Email, @Gender, @IpAddress )
        ";
    }
}
