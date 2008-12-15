using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Stale,
            Pending,
            New,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 55.56;
        public const long BurstFormat = 7100;
        public const long WindowFormat = 2199;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i / 8) == (carry & 255))
                {
                    carry = carry ^ (carry + seed);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
