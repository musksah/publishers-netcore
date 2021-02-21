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
    public class PublisherController : ControllerBase
    {
        private IPublisherData _publisherData;
        public PublisherController(IPublisherData publisherData)
        {
            _publisherData = publisherData;
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetPublishers(int id)
        {
            return Ok(_publisherData.GetPublisher(id));
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddPublisher(Publishers publisher)
        {
            return Ok(_publisherData.AddPublisher(publisher));
        }
    }
}
