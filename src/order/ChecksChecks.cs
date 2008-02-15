using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 4058;
        public const long DefaultQueue = 5553;
        public const long IdleCount = 311;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
