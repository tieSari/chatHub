using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SarinDemoChatti.Server.Services;

namespace SarinDemoChatti.Server.Hubs
{
    public class ChatHub : Hub
    {
        private IDataService dataService;
        public ChatHub(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public async Task SendMessage(string user, string message, string groupName)
        {
            if (user != null && message != null && groupName != null)
            {
                await Clients.All.SendAsync("ReceiveMessage", user, message, groupName);
                dataService.SaveMessage(message, user, groupName);

            }
        }
    }
}