using Library.InterfacesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class SqlBookData : IBookData
    {
        private LibraryContext _libraryContext;
        public SqlBookData(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public Books AddBook(Books book)
        {
            _libraryContext.Books.Add(book);
            _libraryContext.SaveChanges();
            return book;
        }

        public dynamic GetBooks()
        {
            var books = _libraryContext.Books
                                .Join(_libraryContext.Authors,
                                book => book.id_autor,
                                author => author.id,
                                (book, author) => new { book, author })
                                .Join(_libraryContext.Publishers,
                                book => book.book.id_autor,
                                publisher => publisher.id,
                                (book, publisher) => new {
                                    id = book.book.id,
                                    title = book.book.title,
                                    year = book.book.year,
                                    genre = book.book.genre,
                                    number_pages = book.book.number_pages,
                                    id_publisher = book.book.id_publisher,
                                    publisher = publisher.name,
                                    id_autor = book.book.id_autor,
                                    author = book.author.name,
                                }).ToList();
            return books;
        }

        public List<Books> GetBooksByPublisher(int idPublisher)
        {
            var books = _libraryContext.Books.Where(x => x.id_publisher == idPublisher).ToList();
            return books;
        }
    }
}
