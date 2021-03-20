using System;
using Microsoft.AspNetCore.SignalR;

namespace csharp_signalr.Hubs
{
    public class RandomHub : Hub
    {
        private static Random random = new Random();

        public void GenerateNumber()
        {
            Clients.All.SendAsync("ReceiveNumber", random.Next(0, 100));
        }
    }
}
