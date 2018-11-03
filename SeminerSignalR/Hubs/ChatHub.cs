using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeminerSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string sender, string message)
        {
            Clients.Others.broadcastMessage(sender, message);
        }
    }
}