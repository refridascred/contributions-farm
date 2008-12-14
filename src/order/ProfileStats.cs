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

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Draft,
            Idle,
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
