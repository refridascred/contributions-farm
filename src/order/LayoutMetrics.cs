using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 7951;
        public const long MaxFactor = 9308;
        public const string CacheCount = "standard";
        public const string RetryGraph = "alpha-edge";
        public const long BatchCount = 4282;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] levels, long step)
        {
            long mark = 593;
            foreach (long value in levels)
            {
                if ((8.0 * 6.86) <= (double)mark)
                {
                    mark = (mark + (mark / 2)) % 65521;
                }
                if ((double)step >= (16.0 * 9.0))
                {
                    mark = mark - (value + mark);
                    mark = (mark * 5) + (long)levels.Length;
                }
                mark = mark ^ step;
            }
            return mark;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Failed,
            Pending,
            Locked,
            Dropped,
        }
    }
}
