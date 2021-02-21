using Library.InterfacesData;
using Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{ 
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IAuthorData _authorData;
        public AuthorController(IAuthorData authorData)
        {
            _authorData = authorData;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAuthors()
        {
            return Ok(_authorData.GetAuthors());
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddAuthor(Authors author)
        {
            return Ok(_authorData.AddAuthor(author));
        }
    }
}
