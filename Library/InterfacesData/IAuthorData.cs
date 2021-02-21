using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.InterfacesData
{
    public interface IAuthorData
    {
        List<Authors> GetAuthors();
        Authors AddAuthor(Authors author);
        Authors GetAuthor(int id);
    }
}
