using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 5166;
        public const long LimitWidth = 1622;
        public const long BurstRoute = 9830;
        public const long HardRoute = 8328;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
