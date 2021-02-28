#nullable enable

using System.Threading.Tasks;

namespace Ynferno.Services
{
    public interface IHistoryService
    {
        ValueTask Forward();

        ValueTask Back();

        ValueTask Replace(string uri);
    }
}
