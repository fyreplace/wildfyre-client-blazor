#nullable enable

using System.Threading.Tasks;
using Refit;
using Ynferno.Models;

namespace Ynferno.Services
{
    public interface IAuthorService
    {
        [Get("/users/")]
        [Headers("Authorization: Token")]
        Task<Author> GetSelf();
    }
}
