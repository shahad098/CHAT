using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace live.signalr.hubs
{
    public class ChatHub : Hub
    {
        public void send(string name, string massage)
        {
            Clients.All.addNewMessageToPage(name, massage);
        }
    }
}