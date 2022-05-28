using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SarinDemoChatti.Shared.Models;

namespace SarinDemoChatti.Server.Services
{
    public interface IDataService
    {
        public Boolean SaveMessage(MessageInfo messageInfo);

        public Boolean SaveUser(string user);
    }
}
