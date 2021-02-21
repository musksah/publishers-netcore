using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.InterfacesData
{
    public interface IPublisherData
    {
        List<Publishers> GetPublishers();
        Publishers AddPublisher(Publishers publisher);
        Publishers GetPublisher(int id);
    }
}
