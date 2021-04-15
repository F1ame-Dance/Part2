using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Interfaces.TestAPI
{
    public interface IValueService
    {
        IEnumerable<string> Get();

        string Get(int id);
        Uri Create(string value);
        HttpStatusCode Edit(int id, string value);
        HttpStatusCode Remove(int id);

    }
}
