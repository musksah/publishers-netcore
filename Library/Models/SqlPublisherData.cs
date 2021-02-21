using Library.InterfacesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class SqlPublisherData :IPublisherData
    {
        private LibraryContext _libraryContext;
        public SqlPublisherData(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public Publishers AddPublisher(Publishers publisher)
        {
            _libraryContext.Publishers.Add(publisher);
            _libraryContext.SaveChanges();
            return publisher;
        }

        public Publishers GetPublisher(int id)
        {
            var publisher = _libraryContext.Publishers.Find(id);
            return publisher;
        }

        public List<Publishers> GetPublishers()
        {
            throw new NotImplementedException();
        }
    }
}
