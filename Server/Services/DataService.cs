using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SarinDemoChatti.Shared.Models;

namespace SarinDemoChatti.Server.Services
{
    // for saving user info and messages
    public class DataService: IDataService
    {
        public Boolean SaveMessage(MessageInfo messageInfo)
        {
            return true;
        }

        public Boolean SaveUser(string user)
        {
            return true;
        }

    }
}
