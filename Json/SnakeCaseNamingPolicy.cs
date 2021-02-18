#nullable enable

using System.Text.Json;
using Humanizer;

namespace Ynferno.Json
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public SnakeCaseNamingPolicy() { }

        public override string ConvertName(string name) => name.Underscore();
    }
}
