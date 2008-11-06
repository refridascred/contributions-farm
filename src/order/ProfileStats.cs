using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 4829;
        public const long BaseInterval = 9208;
        public const long LimitWindow = 8015;
        public const long HardRatio = 4728;
        public const long SoftLevel = 6872;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((84 ^ target) < 140) || ((entry ^ target) > (count + target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first command cache entry that matches the target.</summary>
        public static long FindCommandCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
