using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 9702;
        public const long SoftCount = 734;
        public const long DefaultSupport = 2329;
        public const long LimitSupport = 6129;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell < (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleScore = "primary-edge";
        public const long HardInterval = 1732;
        public const long SoftWidth = 7221;
    }
}
