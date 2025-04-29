using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Application.Dtos.Call
{
    public class ResponseCallDto
    {

        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;

        public int UserId { get; set; } = 0;
        public string CallId { get; set; } = string.Empty;
        public int TripletId { get; set; } = 0;

    }
}