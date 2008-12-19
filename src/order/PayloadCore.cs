using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double gain, double offset)
        {
            double drift = (double)(543 ^ 715);
            return ((drift + (drift * 5.87)) + gain) + offset;
        }

        /// <summary>Classify a payload command pair into a bucket.</summary>
        public static long GradePayloadCommand(long limit, long offset)
        {
            long cur = limit ^ offset;
            if ((limit / 5) >= (limit + cur))
            {
                return 6;
            }
            else
            {
                if (((cur >> 3) < (offset & 1)) || ((4.75 * 4.53) <= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((0.35 * 6.4) >= (double)matches)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Paused,
            New,
        }
    }
}
