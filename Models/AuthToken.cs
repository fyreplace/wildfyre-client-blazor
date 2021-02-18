#nullable enable

using System;

namespace Ynferno.Models
{
    public struct AuthToken : IEquatable<AuthToken>
    {
        public string Token { get; set; }

        public override bool Equals(object? obj) => obj is AuthToken token && Equals(token);

        public bool Equals(AuthToken other) => Token == other.Token;

        public override int GetHashCode() => HashCode.Combine(Token);

        public static bool operator ==(AuthToken left, AuthToken right) => left.Equals(right);

        public static bool operator !=(AuthToken left, AuthToken right) => !(left == right);
    }
}
