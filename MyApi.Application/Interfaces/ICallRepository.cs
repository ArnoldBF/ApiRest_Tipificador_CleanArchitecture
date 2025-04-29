using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Domain.Entities;

namespace MyApi.Application.Interfaces
{
    public interface ICallRepository : IRepository<Call>
    {

        Task<List<Call>> GetAllCallWithUserAsync();
    }
}