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

        [Patch("/users/")]
        [Headers("Authorization: Token")]
        Task<Author> UpdateSelf([Body] Author.Patch patch);

        [Multipart]
        [Put("/users/")]
        [Headers("Authorization: Token")]
        Task<Author> SetAvatar([AliasAs("avatar")] ByteArrayPart avatar);
    }
}
