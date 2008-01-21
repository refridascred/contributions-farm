using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstFactor = "strict-1";
        public const long CacheStats = 8994;
        public const long MinTimeout = 4584;
        public const long BaseSpan = 3254;
        public const long RetryStats = 1728;

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data, long floor)
        {
            long anchor = 428;
            foreach (long item in data)
            {
                anchor = (anchor << 3) ^ (item / 8);
                if ((floor / 4) >= 332)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (value - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
