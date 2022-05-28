using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SarinDemoChatti.Server.Services;
using SarinDemoChatti.Shared.Models;

namespace SarinDemoChatti.Server.Hubs
{
    public class ChatHub : Hub
    {
        private IDataService dataService;
        public ChatHub(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public async Task SendMessage(MessageInfo messageInfo)
        {
            if (messageInfo.UserName != null && messageInfo.Message != null && messageInfo.GroupName != null)
            {
                await Clients.All.SendAsync("ReceiveMessage", messageInfo);
                dataService.SaveMessage(messageInfo);

            }
        }
    }
}