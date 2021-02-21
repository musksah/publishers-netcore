using Library.InterfacesData;
using Library.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookData _bookData;
        private IPublisherData _publisherData;
        private IAuthorData _authorData;
        public BookController(IBookData bookData, IPublisherData publisherData, IAuthorData authorData)
        {
            _bookData = bookData;
            _publisherData = publisherData;
            _authorData = authorData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetBooks()
        {
            return Ok(_bookData.GetBooks());
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddBook(Books book)
        {
            var publisher = _publisherData.GetPublisher(book.id_publisher);
            var author = _authorData.GetAuthor(book.id_autor);
            if (author == null)
            {
                return BadRequest("El autor no está registrado");
            }
            if(publisher == null)
            {
                return BadRequest("La editorial no está registrada");
            }
            List<Books> booksList = _bookData.GetBooksByPublisher(book.id_publisher);
            if (publisher.maximum_books > booksList.Count)
            {
                return Ok(_bookData.AddBook(book));
            }
            return BadRequest("No es posible registrar el libro, se alcanzó el máximo permitido.");
        }
    }
}
