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

        public class GenerateNumberParameters
        {
            public int? Min { get; set; }
            public int? Max { get; set; }
        }

        public void GenerateNumber(GenerateNumberParameters parameters)
        {
            Clients.All.ReceiveNumber(
                new IRandomClient.ReceiveNumberParameters() {
                    Number = Random.Next(parameters.Min ?? 0, parameters.Max ?? 100)
                }
            );
        }
    }
}
