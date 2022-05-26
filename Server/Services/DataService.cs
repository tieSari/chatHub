using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SarinDemoChatti.Server.Services
{
    // for saving user info and messages
    public class DataService: IDataService
    {
        public Boolean SaveMessage(string message, string user, string groupName)
        {
            return true;
        }

        public Boolean SaveUser(string user)
        {
            return true;
        }

    }
}
