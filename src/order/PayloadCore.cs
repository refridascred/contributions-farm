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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long bound)
        {
            if ((target - target) >= bound)
            {
                return 6;
            }
            else
            {
                if ((8 ^ bound) > target)
                {
                    return 1;
                }
                else
                {
                    if (target <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
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
