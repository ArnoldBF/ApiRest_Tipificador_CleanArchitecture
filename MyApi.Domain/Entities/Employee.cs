namespace MyApi.Domain.Entities
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Ci { get; set; } = string.Empty;

        //Relacion de uno a uno con User

        public User? User { get; set; }

    }
}