using Microsoft.Extensions.Configuration;
using WebStore.Client.Base;

namespace WebStore.Client.Values
{
    public class ValuesClient : BaseClient
    {
        public ValuesClient(IConfiguration Configuration) : base(Configuration, "api/values") { }
        {
        }
    }
}
