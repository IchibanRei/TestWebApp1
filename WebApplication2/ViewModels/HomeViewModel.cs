using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Models.Environment> Envs { get; set; }
        public Models.Environment Env { get; set; }
    }
}
