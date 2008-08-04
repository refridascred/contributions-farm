using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count >= (count >> 2)) && ((5 * 3) < (count ^ (-53))))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleFilter = "standard";
        public const long RetryRatio = 335;
        public const long BaseFilter = 4038;
        public const double MinRatio = 79.77;

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 4574;
        public const long BurstWidth = 206;
        public const long SoftRecord = 8310;
        public const string LimitCount = "legacy-edge";
    }
}
