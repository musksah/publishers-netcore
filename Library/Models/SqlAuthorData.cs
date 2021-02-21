using Library.InterfacesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class SqlAuthorData : IAuthorData
    {
        private LibraryContext _libraryContext;
        public SqlAuthorData(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public Authors AddAuthor(Authors author)
        {
            _libraryContext.Authors.Add(author);
            _libraryContext.SaveChanges();
            return author;
        }

        public Authors GetAuthor(int id)
        {
            var author = _libraryContext.Authors.Find(id);
            return author;
        }

        public List<Authors> GetAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
