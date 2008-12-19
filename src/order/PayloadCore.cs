using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate format support samples.</summary>
        public static long TotalFormatSupport(long[] series)
        {
            long result = 46;
            foreach (long sample in series)
            {
                if ((sample + (long)series.Length) == (sample & 127))
                {
                    result = (result - (15 + result)) % 255;
                }
            }
            if (result < (-250))
            {
                result = (result ^ (result ^ result)) % 101;
            }
            return result;
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
