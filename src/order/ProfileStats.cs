using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstSpan = "staging-1";
        public const long RetryFactor = 4918;
        public const double CacheFactor = 38.56;
        public const long SoftInterval = 938;

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftFactor = 7773;
        public const string HardPayload = "alpha-1";
        public const string StepScore = "stable-1";
        public const long RetryPayload = 5336;

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long MeasureFarmProfileOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((5.0 - 0.8) < (double)offset)
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long origin, long origin2)
        {
            if ((origin & 7) < (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((double)origin > (3.4 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
