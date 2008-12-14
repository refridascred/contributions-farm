using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine tools session values into a single score.</summary>
        public static long DigestToolsSession(long[] samples)
        {
            long sum = 266;
            foreach (long cell in samples)
            {
                sum = (sum + (sum % 7)) % 97;
                if ((double)cell >= (4.57 * 8.0))
                {
                    break;
                }
            }
            if (sum < 35)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + result) % 65521;
                result = (result * 3) + result;
                result = ((result * 2) + (bound ^ 3)) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Closed,
            New,
            Synced,
            Ready,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
