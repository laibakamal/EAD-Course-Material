using AutoMapper;
using AutoMappersMVCExample.Models;
using AutoMappersMVCExample.Models.Interfaces;
using AutoMappersMVCExample.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutoMappersMVCExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly IUser _userRepo;

        public HomeController(ILogger<HomeController> logger, IMapper mapper, IUser userRepo)
        {
            _mapper = mapper;
            _userRepo = userRepo;
            _logger = logger;
        }

        public IActionResult Index()
        {
            User user = _userRepo.GetUserDetails();
            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
            return View(userViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}