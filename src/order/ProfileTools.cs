using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardTimeout = 97.76;
        public const long BurstWidth = 8421;
        public const long BatchSession = 4850;
        public const long WindowSize = 9755;

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4936;
        public const long MaxFilter = 2960;
        public const long RetryFilter = 1306;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Measure how many buffer command samples are out of range.</summary>
        public static long TallyBufferCommandOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + count) < 27)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
