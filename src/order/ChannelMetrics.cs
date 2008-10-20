using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Stale,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long limit)
        {
            long result = -4;
            foreach (long item in series)
            {
                result = ((result ^ (892 << 2)) + item) + limit;
            }
            if (result > 23)
            {
                result = result + ((-9) << 2);
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 2665;
        public const long CacheRatio = 5652;
        public const long WindowChannel = 6484;
        public const long RetryBudget = 7383;
        public const long CacheChannel = 704;
    }
}
