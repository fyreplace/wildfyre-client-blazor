#nullable enable

using System;

namespace Ynferno.Models
{
    public struct Author : IEquatable<Author>
    {
        public long User { get; set; }
        public string Name { get; set; }
        public string? Avatar { get; set; }
        public string Bio { get; set; }
        public bool Banned { get; set; }

        public override bool Equals(object? obj) => obj is Author author && Equals(author);

        public bool Equals(Author other) => User == other.User;

        public override int GetHashCode() => HashCode.Combine(User);

        public static bool operator ==(Author left, Author right) => left.Equals(right);

        public static bool operator !=(Author left, Author right) => !(left == right);

        public struct Patch
        {
            public string Bio { get; set; }
        }
    }
}
