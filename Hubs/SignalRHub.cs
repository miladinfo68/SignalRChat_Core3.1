using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace realtimeChatApp.Hubs
{
    public class SignalRHub:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("BroadcastMessage", user, message);
        }
    }
}