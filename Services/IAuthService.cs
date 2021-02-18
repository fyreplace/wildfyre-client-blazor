#nullable enable

using System.Threading.Tasks;
using Refit;
using Ynferno.Models;

namespace Ynferno.Services
{
    public interface IAuthService
    {
        [Post("/account/auth/")]
        Task<AuthToken> Login([Body] Credentials credentials);
    }
}
