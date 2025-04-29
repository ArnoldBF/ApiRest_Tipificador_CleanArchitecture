using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyApi.Domain.Entities
{
    public class User
    {

        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;


        //Relacion de uno a uno con Person
        public int EmployeeId { get; set; }
        [JsonIgnore]
        public Employee Employee { get; set; } = null!;

        //Relacion de uno a muchos con Call

        public ICollection<Call> Calls { get; set; } = new List<Call>();



    }
}