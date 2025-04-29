using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyApi.Domain.Entities
{
    public class Call
    {
        public int Id { get; set; }

        public string Comment { get; set; } = string.Empty;

        public DateOnly TypificationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public TimeOnly TypificationTime { get; set; } = TimeOnly.FromDateTime(DateTime.Now);

        public string CallId { get; set; } = string.Empty;

        // Relacion de mucho a uno con user
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; } = null!;

        // Relacion de muchos a uno con Triplet
        public int TripletId { get; set; }

        [JsonIgnore]
        public Triplet Triplet { get; set; } = null!;
    }
}