using System.Threading.Tasks;

namespace csharp_signalr.Hubs
{
    public interface IRandomClient
    {
        Task ReceiveNumber(int number);
    }
}
