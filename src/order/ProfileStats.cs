using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCount = "open-edge";
        public const double BatchCache = 50.57;
        public const long SoftBudget = 1200;
        public const long BaseRatio = 1840;

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (5.02 <= (double)tally)
                {
                    tally = ((tally + 3) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long origin)
        {
            long gap = floor ^ origin;
            if ((floor / 7) > floor)
            {
                return 7;
            }
            else
            {
                if (((double)gap == (double)floor) || ((origin / 3) >= 230))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
