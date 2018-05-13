using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SkipperWebApi.Models;
using Users.Domain;
using Users.Service;

namespace SkipperWebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IUsersService _userService;
        private IMapper _mapper;


        public UsersController(IUsersService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            var users = _userService.GetAllUsers();
            return _mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(users);
        }
    }
}