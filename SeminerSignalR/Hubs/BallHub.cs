using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeminerSignalR.Hubs
{
    public class BallHub : Hub
    {
        public void Move(int left, int top)
        {
            Clients.Others.moveBall(left, top);
        }
    }
}