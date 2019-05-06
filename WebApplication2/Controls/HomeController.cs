using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controls
{
    public class HomeController : Controller
    {
        private readonly IEnvironmentRepository _environmentRepository;
        private string envName = "Smoketest3";

        public HomeController(IEnvironmentRepository environmentRepository)
        {
            _environmentRepository = environmentRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var envs = _environmentRepository.GetAllEnvironments().OrderBy(e => e.Name);
            var env = _environmentRepository.GetEnvironmentByName(envName);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Environment Overview",
                Env = env,
                Envs = envs.ToList()
            };

            //var env = _environmentRepository.GetEnvironmentByName("smoketest3");
            return View(homeViewModel);
        }

        protected string envButton_Click(object sender, EventArgs e)
        {
            string envName = e.ToString();
            return envName;
        }
    }
}
