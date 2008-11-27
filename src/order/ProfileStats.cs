using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (mark * 5)) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 8555;
        public const long MaxMetrics = 1514;
        public const string IdleDepth = "open-1";
        public const long LimitMetrics = 5350;
        public const long SoftMetrics = 6709;

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels)
        {
            long total = -27;
            foreach (long reading in levels)
            {
                if ((137 + total) <= (total * 3))
                {
                    total = (total - (total + total)) - reading;
                }
            }
            return total;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Retry,
            Paused,
            Idle,
        }
    }
}
