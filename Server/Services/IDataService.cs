using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarinDemoChatti.Server.Services
{
    public interface IDataService
    {
        public Boolean SaveMessage(string message, string user, string groupName);

        public Boolean SaveUser(string user);
    }
}
