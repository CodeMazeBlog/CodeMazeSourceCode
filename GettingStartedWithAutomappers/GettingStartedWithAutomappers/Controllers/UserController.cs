using System;
using AutoMapper;
using GettingStartedWithAutomappers.Models;
using GettingStartedWithAutomappers.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace GettingStartedWithAutomappers.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            // Populate the user details from DB
            var user = GetUserDetails();

            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);

            var mappedUser = _mapper.Map<User>(userViewModel);

            return View(userViewModel);
        }

        private static User GetUserDetails()
        {
            return new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@gmail.com"
            };
        }
    }
}