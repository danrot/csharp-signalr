using System.Threading.Tasks;

namespace csharp_signalr.Hubs
{
    public interface IRandomClient
    {
        public class ReceiveNumberParameters
        {
            public int Number { get; set; }
        }

        Task ReceiveNumber(ReceiveNumberParameters parameters);
    }
}
