using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = carry + carry;
                carry = (carry + (20 - origin)) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((19.0 + 6.07) >= (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstSpan = 62.86;
        public const long BaseSize = 6877;
        public const long DefaultStats = 5957;
        public const long MaxStats = 9690;
        public const double RetryDepth = 74.71;
    }
}
