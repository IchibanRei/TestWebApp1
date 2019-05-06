using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public interface IEnvironmentRepository
    {
        IEnumerable<Environment> GetAllEnvironments();

        Environment GetEnvironmentByName(string envName);
    }
}
