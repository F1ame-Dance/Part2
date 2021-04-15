using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Client.Base
{
    public abstract class BaseClient
    {
        protected string Address { get; set; }
        protected HttpClient Http { get; set; }

        protected BaseClient(IConfiguration Configuration, string ServiceAddress)
        {
            Address = ServiceAddress;
            Http = new HttpClient
            {
                BaseAddress = new Uri(Configuration["WebApiURL"]),
                DefaultRequestHeaders =
                {
                    Accept = { new MediaTypeWithQualityHeaderValue("application/json")}
                }
            };

        }
    }
}
