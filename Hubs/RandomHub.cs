using System;
using Microsoft.AspNetCore.SignalR;

namespace csharp_signalr.Hubs
{
    public class RandomHub : Hub<IRandomClient>
    {
        private Random Random { get; }

        public RandomHub(Random random)
        {
            Random = random;
        }

        public void GenerateNumber()
        {
            Clients.All.ReceiveNumber(Random.Next(0, 100));
        }
    }
}
