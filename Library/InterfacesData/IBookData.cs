using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.InterfacesData
{
    public interface IBookData
    {
        dynamic GetBooks();
        Books AddBook(Books book);
        List<Books> GetBooksByPublisher(int idPublisher);
    }
}
