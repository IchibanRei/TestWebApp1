using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Environment
    {
        public string Name { get; set; }
        public string ServerPool { get; set; }
        public string ServerName { get; set; }
        public string Status { get; set; }
        public string Build { get; set; }
        public string Date { get; set; }
        public string PoolType { get; set; }
    }
}
